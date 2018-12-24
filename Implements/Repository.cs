using LibraryAmoCRM.Infarstructure;
using LibraryAmoCRM.Infarstructure.Exceptions;
using LibraryAmoCRM.Interfaces;
using LibraryAmoCRM.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LibraryAmoCRM.Implements
{
    public class Repository<T>: IQueryParam, IRepository<T> where T : CoreDTO
    {
        public List<KeyValuePair<string, string>> QueryParameters { get; set; }

        public Func<Task<IEnumerable<T>>> Execute { get; set; }

        Connection connection;

        ILoggerFactory loggerFactory;
        ILogger currentLogger;

        public Repository(Connection connection, ILoggerFactory loggerFactory)
        {
            this.connection = connection;
            QueryParameters = new List<KeyValuePair<string, string>>();

            this.loggerFactory = loggerFactory;
            this.currentLogger = loggerFactory.CreateLogger(this.ToString());
        }

        public IRepository<T> Get() 
        {
            Execute = GetItemsMetod;
            return this;
        }

        public async Task<IEnumerable<T>> Add(IEnumerable<T> items)
        {
            var updatedObjects = items;
            updatedObjects.ToList().ForEach( (e) => e.UpdatedAt = DateTime.Now );

            var result = await Adding(updatedObjects.ToArray());

            return result;
        }

        public async Task<T> Add(T item)
        {
            var updatedObject = item;
            updatedObject.UpdatedAt = DateTime.Now;

            var result = await Adding(new[] { updatedObject });

            return result?.FirstOrDefault(); ;
        }

        protected async Task<IEnumerable<T>> Adding( Array items)
        {
            IEnumerable<T> result = null;

            var obj = new
            {
                add = items
            };

            try
            {
                Connection.Waiting();

                using (var client = connection.GetClient<T>())
                {
                    var request = client.PostAsync( "", obj, new MediaTypesFormatters().PostJsonFormatter() ).Result;
                    request.EnsureSuccessStatusCode();

                    var response = await request.Content.ReadAsAsync<HAL<T>>( new MediaTypesFormatters().GetHALFormatter() );

                    result = response._embedded.items;
                }

                currentLogger.LogInformation("Добавлены записи -  {Id}, {Type}", result?.Select(x=>x.Id), typeof(T).Name);                
            }
            catch (HttpRequestException ex)
            {
                currentLogger.LogWarning(ex, "HTTP Ошибка при добавлении записи {Type}", typeof(T).Name);
            }
            catch (Exception ex)
            {
                currentLogger.LogWarning(ex,"Ошибка при добавлении записи {Type}", typeof(T).Name);
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
                    var @params = BuildQueryParams();
                    var request = await client.GetAsync(@params);
                    currentLogger.LogInformation("Запрос записей - {Type} по параметрам - {Params}", typeof(T).Name, @params);
                    request.EnsureSuccessStatusCode();

                    var response = request.Content.ReadAsAsync<HAL<T>>( new MediaTypesFormatters().GetHALFormatter() );

                    result = response?.Result?._embedded?.items;
                }

                currentLogger.LogInformation("Получено - {Count} записей | Id - {Array} | {Type} ", result?.Count(), result?.Select(i => i.Id), typeof(T).Name);

                return result;
            }
            catch (HttpRequestException ex)
            {
                currentLogger.LogWarning(ex, "HTTP Ошибка при чтении записи {Type}", typeof(T).Name);
                return null;
            }
            catch (Exception ex)
            {
                currentLogger.LogWarning(ex, "Ошибка при чтении записи {Type}", typeof(T).Name);
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

                    currentLogger.LogInformation("Обновлена запись -  {Id}, {Type} / Ответ crm - {Response}", item.Id, typeof(T).Name, jsonResult);
                }
            }
            catch (HttpRequestException ex)
            {
                currentLogger.LogWarning(ex, "HTTP Ошибка при обновлении записи {Type}, {@Request}", typeof(T).Name, request);
            }
            catch (Exception ex)
            {
                currentLogger.LogWarning(ex, "Ошибка при обновлении записи {Type}", typeof(T).Name);
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
