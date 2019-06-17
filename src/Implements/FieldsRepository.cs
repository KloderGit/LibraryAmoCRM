using LibraryAmoCRM.Infarstructure;
using LibraryAmoCRM.Misc;
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
        Connection connection;

        public FieldsRepository(Connection connection)
        {
            this.connection = connection;
        }

        public FieldsRepository(HttpClient client)
        {
            this.client = client;
        }

        public async Task<Account> GetAccount()
        {
            try
            {
                var clientt = connection.Client;
                var endpoint = connection.GetEndPoint<Account>();
                var @params = "?with=custom_fields,users,messenger,notifications,pipelines,groups,note_types,task_types";

                var request = await clientt.GetAsync(endpoint + @params);
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
