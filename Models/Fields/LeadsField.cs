using Newtonsoft.Json;
using ServiceLibraryAmoCRM.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLibraryAmoCRM.Models
{
    public class LeadsField : IHaveIdArray
    {
        [JsonProperty(PropertyName = "id")]
        public IEnumerable<int> IDs { get; set; }
    }
}
