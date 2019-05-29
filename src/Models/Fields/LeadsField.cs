using Newtonsoft.Json;
using LibraryAmoCRM.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Models
{
    public class LeadsField : IHaveIdArray
    {
        [JsonProperty(PropertyName = "id")]
        public IEnumerable<int> IDs { get; set; }
    }
}
