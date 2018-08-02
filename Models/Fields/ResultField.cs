using Newtonsoft.Json;
using ServiceLibraryAmoCRM.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLibraryAmoCRM.Models
{
    public class ResultField : IHaveIdSingle
    {
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
    }
}
