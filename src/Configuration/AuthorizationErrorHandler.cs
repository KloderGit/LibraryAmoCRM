using LibraryAmoCRM.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAmoCRM.Configuration
{
    public class AuthorizationErrorHandler : DelegatingHandler
    {
        Action action;
        public AuthorizationErrorHandler( Action action )
        {
            this.action = action;
        }

        protected override async Task<HttpResponseMessage> SendAsync( HttpRequestMessage request,
            System.Threading.CancellationToken cancellationToken)
        {
            var response = await base.SendAsync(request, cancellationToken);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                action?.Invoke();
            }

            return response;
        }
    }
}
