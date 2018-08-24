using Newtonsoft.Json;
using LibraryAmoCRM.Infarstructure.JsonConverters;
using System;
using System.Collections.Generic;
using System.Net.Http.Formatting;
using System.Text;

namespace LibraryAmoCRM.Infarstructure
{
    internal class MediaTypesFormatters
    {
        public IEnumerable<MediaTypeFormatter> GetHALFormatter()
        {
            return new MediaTypeFormatter[] {
                new HalJsonFormatter()
            };
        }

        public MediaTypeFormatter PostJsonFormatter()
        {
            var serializerSettings = new JsonSerializerSettings()
            {
                ContractResolver = new ChangeNameContractResolver(true),
                NullValueHandling = NullValueHandling.Ignore
            };

            var formatter = new JsonMediaTypeFormatter();

            formatter.SerializerSettings = serializerSettings;

            return formatter;
        }
    }
}
