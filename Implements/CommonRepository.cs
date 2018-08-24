using LibraryAmoCRM.Infarstructure;
using LibraryAmoCRM.Infarstructure.Exceptions;
using LibraryAmoCRM.Interfaces;
using LibraryAmoCRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LibraryAmoCRM.Implements
{
    public class CommonRepository<T>: IAcceptParams, ICommonRepository<T> where T : CoreDTO
    {
        HttpClient client;

        public List<KeyValuePair<string, string>> QueryParameters { get; set; }

        public Func<Task<IEnumerable<T>>> Execute { get; set; }

        public CommonRepository(HttpClient client)
        {
            this.client = client;
            QueryParameters = new List<KeyValuePair<string, string>>();
        }

        ~CommonRepository(){ client.Dispose(); }

        public CommonRepository<T> Get() 
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
                var request = client.PostAsync("", obj, new MediaTypesFormatters().PostJsonFormatter()).Result;
                request.EnsureSuccessStatusCode();

                var response = await request.Content.ReadAsAsync<HAL<T>>(new MediaTypesFormatters().GetHALFormatter());

                result = response._embedded.items.FirstOrDefault();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        protected async Task<IEnumerable<T>> GetItemsMetod()
        {
            try
            {
                var request = await client.GetAsync(BuildQueryParams());
                request.EnsureSuccessStatusCode();

                var response = request.Content.ReadAsAsync<HAL<T>>( new MediaTypesFormatters().GetHALFormatter() );

                return response?.Result?._embedded?.items;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public void Update(T item) {

            var updatedObject = item;
            updatedObject.UpdatedAt = DateTime.Now;

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

            try
            {
                var request = client.PostAsync("", obj, new MediaTypesFormatters().PostJsonFormatter() ).Result;
                request.EnsureSuccessStatusCode();

                var response = request.Content.ReadAsAsync<HAL<T>>( new MediaTypesFormatters().GetHALFormatter() );
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
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

            //if (QueryParameters.Select(x => x.Key).Count() > 0) { client.DefaultRequestHeaders.Add("IF-MODIFIED-SINCE", DateTime.Now.ToUniversalTime().ToString() ); }

            var result = new FormUrlEncodedContent(QueryParameters).ReadAsStringAsync().Result;
            QueryParameters.Clear();

            return String.IsNullOrEmpty(result) ? "" : "?" + result;
        }
    }
}
