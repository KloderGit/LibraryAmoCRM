using LibraryAmoCRM.Configuration;
using Serilog;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;

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
            handler.UseCookies = true;
        }

        public HttpClient GetClient(Uri query)
        {
            var client = new HttpClient(handler);
            client.BaseAddress = query;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
            client.DefaultRequestHeaders.ConnectionClose = false;
            client.DefaultRequestHeaders.Connection.Add("Keep-Alive");
            return client;
        }

        public void Auth(object logger) // Object нужен для соответствия сигнатуре делегата TimerCallback
        {
            var requestParams = new Dictionary<string, string>
                    {
                        { "USER_LOGIN", config.User},
                        { "USER_HASH", config.Password }
                    };

            var client = this.GetClient(config.Url.Auth);
            var content = new FormUrlEncodedContent(requestParams);
            var response = client.PostAsync("", content).Result;
            var responseData = response.Content.ReadAsStringAsync().Result;

            ((ILogger)logger).Information("CRM | Запрос на авторизацию. {Time}, Результат - {@Result}", DateTime.Now.ToString(), responseData);
        }
    }
}
