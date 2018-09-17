using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Models.SysModels
{
    public class Account : HALSelf
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "subdomain")]
        public string SubDomain { get; set; }

        [JsonProperty(PropertyName = "currency")]
        public string Curency { get; set; }

        [JsonProperty(PropertyName = "timezone")]
        public string TimeZone { get; set; }

        [JsonProperty(PropertyName = "timezone_offset")]
        public string TimeZoneOffset { get; set; }

        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }

        [JsonProperty(PropertyName = "date_pattern")]
        public DatePattern DatePattern { get; set; }

        [JsonProperty(PropertyName = "current_user")]
        public int CurrentUser { get; set; }

        [JsonProperty("_embedded")]
        public AccountEmbedded Embedded { get; set; }
    }
}
