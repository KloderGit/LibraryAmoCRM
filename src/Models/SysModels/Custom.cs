using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Models.SysModels
{
    public partial class Custom
    {
        [JsonProperty("contacts")]
        public Dictionary<int, Field> Contacts { get; set; }

        [JsonProperty("leads")]
        public Dictionary<int, Field> Leads { get; set; }

        [JsonProperty("companies")]
        public Dictionary<int, Field> Companies { get; set; }

        [JsonProperty("catalogs")]
        public Dictionary<int, Dictionary<int, Field>> Catalogs { get; set; }
    }
}
