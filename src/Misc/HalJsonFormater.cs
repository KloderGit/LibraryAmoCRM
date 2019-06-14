using System;
using System.Collections.Generic;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;

namespace LibraryAmoCRM.Misc
{
    internal class HalJsonFormatter : JsonMediaTypeFormatter
    {
        public HalJsonFormatter()
        {
            SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/hal+json"));
        }
    }
}
