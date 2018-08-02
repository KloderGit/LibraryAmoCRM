using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLibraryAmoCRM.Models
{
    public abstract class BasicServiceEntity : CoreDTO
    {
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "element_id")]
        public Int32? ElementId { get; set; }

        [JsonProperty(PropertyName = "element_type")]
        public int? ElementType { get; set; }
    }
}
