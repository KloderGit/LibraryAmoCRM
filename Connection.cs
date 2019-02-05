using LibraryAmoCRM.Configuration;
using LibraryAmoCRM.Implements;
using LibraryAmoCRM.Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryAmoCRM
{
    public class Connection
    {
        AssemblyConfig config;

        CookieCollection cookies = new CookieCollection();
        HttpClientHandler handler = new HttpClientHandler();

        DateTime lastConnectionTime;

        public static DateTime LastQueryTime { get; set; } = DateTime.Now;

        ILogger logger;

        public Connection(string account, string user, string hash)
        {
            config = new AssemblyConfig( account, user, hash );

            this.logger = new LoggerConfiguration()
                 .WriteTo.Seq( "http://logs.fitness-pro.ru:5341" )
                 .CreateLogger();

            logger.Information("Создан объект подключения к AmoCRM");

            Timer keepConnection = new Timer(
                new TimerCallback(Auth),
                lastConnectionTime, 
                780000, 
                780000 );
        }

        public void Auth(object lastConnect) // Object нужен для соответствия сигнатуре делегата TimerCallback
        {
            using (var client = GetClient( config.Url.Auth ))
            {
                var requestParams = new Dictionary<string, string>
                    {
                        { "USER_LOGIN", config.User},
                        { "USER_HASH", config.Password }
                    };


                var content = new FormUrlEncodedContent( requestParams );
                var response = client.PostAsync( "", content ).Result;

                var updateTime = DateTime.Now;

                var offesTime = updateTime - (DateTime)lastConnect;

                this.lastConnectionTime = updateTime;

                var responseData = response.Content.ReadAsStringAsync().Result;

                cookies = handler.CookieContainer.GetCookies( new Uri( "https://apfitness.amocrm.ru/" ) );

                logger.Information("AmoCRM Авторизация. {Time}, с разницей - {@Minutes}", DateTime.Now.ToString(), offesTime.Minutes);
            }
        }

        ~Connection()
        {
            ( (ILogger)logger ).Information( "AmoCRM Авторизация - Объект уничтожен " );
        }

        public HttpClient GetClient<T>()
        {
            var client = new HttpClient( GetHandler() );
            client.BaseAddress = config.Url.GetUrl<T>();
            FillClientProperty( client );

            return client;
        }

        public HttpClient GetClient(Uri uri)
        {
            var client = new HttpClient( GetHandler() );
            client.BaseAddress = uri;
            FillClientProperty( client );

            return client;
        }

        private void FillClientProperty(HttpClient client)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add( new MediaTypeWithQualityHeaderValue( "application/json" ) );
            client.DefaultRequestHeaders.Accept.Add( new MediaTypeWithQualityHeaderValue( "application/x-www-form-urlencoded" ) );
        }

        private HttpClientHandler GetHandler()
        {
            handler = new HttpClientHandler();

            handler.CookieContainer = new CookieContainer();
            if (cookies.Count > 0) handler.CookieContainer.Add( cookies );

            handler.UseCookies = true;
            handler.UseDefaultCredentials = true;

            return handler;
        }

        
        public static void Waiting()
        {
            var difftime = DateTime.Now.Subtract( Connection.LastQueryTime );

            if (difftime.Milliseconds < 1000)
                Thread.Sleep( 1000 - difftime.Milliseconds );
            LastQueryTime = DateTime.Now;
        }
    }
}
