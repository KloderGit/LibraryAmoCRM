using LibraryAmoCRM.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace LibraryAmoCRM
{
    internal class AmoHTTPClient
    {
        AssemblyConfig config;
        HttpClientHandler handler = new HttpClientHandler();

        public AmoHTTPClient(AssemblyConfig config)
        {
            this.config = config;

            handler.CookieContainer = new System.Net.CookieContainer();
        }

        public HttpClient GetClient(Uri query)
        {
            var client = new HttpClient(handler);
            client.BaseAddress = query;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
            return client;
        }

        public void Auth() {
            var requestParams = new Dictionary<string, string>
                    {
                        { "USER_LOGIN", config.User},
                        { "USER_HASH", config.Password }
                    };

            var client = this.GetClient(config.Url.Auth);
            var content = new FormUrlEncodedContent(requestParams);
            var response = client.PostAsync("", content).Result;
            var responseData = response.Content.ReadAsStringAsync().Result;
        }
    }
}
