using LibraryAmoCRM.Infarstructure;
using LibraryAmoCRM.Models;
using LibraryAmoCRM.Models.SysModels;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace LibraryAmoCRM.Implements
{
    public class FieldsRepository
    {
        HttpClient client;

        public FieldsRepository(HttpClient client)
        {
            this.client = client;
        }

        public async Task<Account> GetAccount()
        {
            try
            {
                var request = await client.GetAsync("?with=custom_fields,users,messenger,notifications,pipelines,groups,note_types,task_types");
                request.EnsureSuccessStatusCode();

                var response = request.Content.ReadAsAsync<Account>(new MediaTypesFormatters().GetHALFormatter());

                return response.Result;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
