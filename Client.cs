using LibraryAmoCRM.Configuration;
using LibraryAmoCRM.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAmoCRM
{
    public class Client : HttpClient
    {
        QueryPerSecond lastQueryTime = new QueryPerSecond();

        public Client(HttpClientHandler handler) : base(handler)
        {
            this.DefaultRequestHeaders.Accept.Clear();
            this.DefaultRequestHeaders.Accept.Add( new MediaTypeWithQualityHeaderValue( "application/json" ) );
            this.DefaultRequestHeaders.Accept.Add( new MediaTypeWithQualityHeaderValue( "application/x-www-form-urlencoded" ) );
            this.DefaultRequestHeaders.ConnectionClose = false;
            this.DefaultRequestHeaders.Connection.Add( "Keep-Alive" );
        }

    }
}
