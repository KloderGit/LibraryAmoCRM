using ServiceLibraryAmoCRM.Infarstructure;
using ServiceLibraryAmoCRM.Infarstructure.Exceptions;
using ServiceLibraryAmoCRM.Interfaces;
using ServiceLibraryAmoCRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ServiceLibraryAmoCRM.Implements
{
    public class CommonRepository<T>: IAcceptParams where T : CoreDTO
    {
        HttpClient client;

        public List<KeyValuePair<string, string>> QueryParameters { get; set; }

        public Func<Task<IEnumerable<T>>> Execute;

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

            var updatedObject = (T)item;
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
