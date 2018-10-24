using LibraryAmoCRM.Configuration;
using LibraryAmoCRM.Infarstructure;
using LibraryAmoCRM.Infarstructure.Exceptions;
using LibraryAmoCRM.Interfaces;
using LibraryAmoCRM.Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryAmoCRM.Implements
{
    public class Repository<T>: IQueryParam, IRepository<T> where T : CoreDTO
    {
        public List<KeyValuePair<string, string>> QueryParameters { get; set; }

        public Func<Task<IEnumerable<T>>> Execute { get; set; }

        Connection connection;

        private ILogger logger;

        public Repository(Connection connection, ILogger logger)
        {
            this.connection = connection;
            QueryParameters = new List<KeyValuePair<string, string>>();
            this.logger = logger;
        }

        public IRepository<T> Get() 
        {
            Execute = GetItemsMetod;
            return this;
        }

        public async Task<T> Add(T item)
        {
            T result = null;

            var updatedObject = item;
            updatedObject.UpdatedAt = DateTime.Now;

            var obj = new
            {
                add = new[] {
                    updatedObject
                }
            };

            try
            {
                Connection.Waiting();

                using (var client = connection.GetClient<T>())
                {
                    var request = client.PostAsync( "", obj, new MediaTypesFormatters().PostJsonFormatter() ).Result;
                    request.EnsureSuccessStatusCode();

                    var response = await request.Content.ReadAsAsync<HAL<T>>( new MediaTypesFormatters().GetHALFormatter() );

                    result = response._embedded.items?.FirstOrDefault();
                }

                logger.Information(GetType().Assembly.GetName().Name + " | Добавлена запись -  {Id}, {Type}", result?.Id, typeof(T).Name);
            }
            catch (HttpRequestException ex)
            {
                logger.Warning(ex, GetType().Assembly.GetName().Name + " | HTTP Ошибка при добавлении записи {Type}", typeof(T).Name);
            }
            catch (Exception ex)
            {
                logger.Warning(ex, GetType().Assembly.GetName().Name + " | Ошибка при добавлении записи {Type}", typeof(T).Name);
            }

            return result;
        }

        protected async Task<IEnumerable<T>> GetItemsMetod()
        {
            IEnumerable<T> result = null;

            try
            {
                Connection.Waiting();

                using (var client = connection.GetClient<T>())
                {
                    var request = await client.GetAsync( BuildQueryParams() );
                    request.EnsureSuccessStatusCode();

                    var response = request.Content.ReadAsAsync<HAL<T>>( new MediaTypesFormatters().GetHALFormatter() );

                    result = response?.Result?._embedded?.items;
                }                

                logger.Information(GetType().Assembly.GetName().Name + " | Получено - {Count} записей | Id - {Array} | {Type} ", result?.Count(), result?.Select(i=>i.Id), typeof(T).Name);

                return result;
            }
            catch (HttpRequestException ex)
            {
                logger.Warning(ex, GetType().Assembly.GetName().Name + " | HTTP Ошибка при чтении записи {Type}", typeof(T).Name);
                return null;
            }
            catch (Exception ex)
            {
                logger.Warning(ex, GetType().Assembly.GetName().Name + " | Ошибка при чтении записи {Type}", typeof(T).Name);
                return null;
            }
        }

        public async Task Update(T item) {

            var updatedObject = item;
            if (item.UpdatedAt.HasValue) {  updatedObject.UpdatedAt = item.UpdatedAt.Value.AddMilliseconds(500); }
            else {  updatedObject.UpdatedAt = DateTime.Now; }

            var obj = new
            {
                update = new[] {
                    updatedObject
                }
            };

            if (updatedObject.Id == null || updatedObject.Id == 0)
            {
                throw new IncorectQueryException("Не указан ID");
            }

            HttpResponseMessage request = null;

            try
            {
                Connection.Waiting();

                using (var client = connection.GetClient<T>())
                {
                    request = await client.PostAsync( "", obj, new MediaTypesFormatters().PostJsonFormatter() );
                    request.EnsureSuccessStatusCode();

                    var response = request.Content.ReadAsAsync<HAL<T>>( new MediaTypesFormatters().GetHALFormatter() );
                    var jsonResult = await request.Content.ReadAsStringAsync();

                    logger.Information( GetType().Assembly.GetName().Name + " | Обновлена запись -  {Id}, {Type} / Ответ crm - {Response}", item.Id, typeof( T ).Name, jsonResult );
                }
            }
            catch (HttpRequestException ex)
            {
                logger.Warning(ex, GetType().Assembly.GetName().Name + " | HTTP Ошибка при обновлении записи {Type}, {@Request}", typeof(T).Name, request);
            }
            catch (Exception ex)
            {
                logger.Warning(ex, GetType().Assembly.GetName().Name + " | Ошибка при обновлении записи {Type}", typeof(T).Name);
            }
        }

        protected string BuildQueryParams()
        {
            QueryParameters = QueryParameters.Distinct().ToList();

            var prerp = new List<KeyValuePair<string, string>>();

            if (QueryParameters.Where(i => i.Key == "id").Count() > 1)
            {
                foreach (var m in QueryParameters)
                {
                    if (m.Key == "id")
                    {
                        prerp.Add(new KeyValuePair<string, string>("id[]", m.Value));
                    }
                    else
                    {
                        prerp.Add(m);
                    }
                }
                QueryParameters = prerp;
            }

            if (QueryParameters.FirstOrDefault(x => x.Key == "limit_offset").Key != null
                  & QueryParameters.FirstOrDefault(x => x.Key == "limit_rows").Key == null)
            {
                throw new IncorectQueryException("Запрос Offset без установленного Limit");
            }

            var result = new FormUrlEncodedContent(QueryParameters).ReadAsStringAsync().Result;
            QueryParameters.Clear();

            return String.IsNullOrEmpty(result) ? "" : "?" + result;
        }
    }
}
