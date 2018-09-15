using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Models.SysModels
{
    public class PipeLine
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "sort")]
        public string Sort { get; set; }

        [JsonProperty(PropertyName = "is_main")]
        public bool isMain { get; set; }

        [JsonProperty(PropertyName = "statuses")]
        public IEnumerable<Status> Statuses { get; set; }
    }
}
