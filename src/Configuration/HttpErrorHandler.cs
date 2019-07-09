using LibraryAmoCRM.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static LibraryAmoCRM.Connection;

namespace LibraryAmoCRM.Configuration
{
    class HttpErrorHandler : DelegatingHandler
    {
        AssemblyConfig config;
        AccountStateHandler handler;

        public HttpErrorHandler(AssemblyConfig config, AccountStateHandler handler)
        {
            this.handler = handler;
            this.config = config;
        }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {
            var response = await base.SendAsync(request, cancellationToken);

            var errrr = response.Content.ReadAsStringAsync().Result;


            if (!response.IsSuccessStatusCode)
            {

                handler("asdasdasd");

                //var rrrrrrr = result.Content.ReadAsStringAsync().Result;
            }
            return response;
        }
    }
}
