using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Models.SysModels
{
    public class DatePattern
    {
        [JsonProperty(PropertyName = "date")]
        public string Date { get; set; }

        [JsonProperty(PropertyName = "time")]
        public string Time { get; set; }

        [JsonProperty(PropertyName = "date_time")]
        public string DateTime { get; set; }

        [JsonProperty(PropertyName = "time_full")]
        public string TimeFull { get; set; }
    }
}
