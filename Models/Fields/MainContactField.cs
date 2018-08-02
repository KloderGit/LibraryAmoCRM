using Newtonsoft.Json;
using ServiceLibraryAmoCRM.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLibraryAmoCRM.Models.Fields
{
    public class MainContactField : IHaveIdSingle
    {
        [JsonProperty(PropertyName = "id")]
        public Int32? Id { get; set; }
    }
}
