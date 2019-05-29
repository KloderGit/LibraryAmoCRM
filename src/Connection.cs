using LibraryAmoCRM.Configuration;
using LibraryAmoCRM.Implements;
using LibraryAmoCRM.Interfaces;
using LibraryAmoCRM.Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryAmoCRM
{
    public class Connection : IConnection
    {
        AssemblyConfig config;

        public HttpClient Client { get; set; }
        private HttpClientHandler handler = new HttpClientHandler();

        ILogger logger;

        public Connection(string account, string user, string hash)
        {
            config = new AssemblyConfig( account, user, hash );

            handler = new HttpClientHandler
            {
                CookieContainer = new CookieContainer(),
                UseCookies = true,
                UseDefaultCredentials = true
            };

            Client = new HttpClient(handler);
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
            Client.BaseAddress = config.Url.Base;

            this.logger = new LoggerConfiguration()
                 .WriteTo.Seq( "http://logs.fitness-pro.ru:5341" )
                 .CreateLogger();

            logger.Information("Создан объект подключения к AmoCRM");

            Timer keepConnection = new Timer(
                new TimerCallback(Auth),
                null,
                0,
                420000);

            //Auth(null);
        }

        public void Auth(object obj)
        {
                var requestParams = new Dictionary<string, string>
                    {
                        { "USER_LOGIN", config.User},
                        { "USER_HASH", config.Password }
                    };

                var content = new FormUrlEncodedContent( requestParams );
                var response = Client.PostAsync(config.Url.Auth, content ).Result;
            //var responseData = response.Content.ReadAsStringAsync().Result;
        }

        ~Connection()
        {
            ( (ILogger)logger ).Information( "AmoCRM Авторизация - Объект уничтожен " );
        }

        public string GetEndPoint<T>()
        {
            return config.Url.GetUrl<T>().AbsolutePath;
        }

    }
}
