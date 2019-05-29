using Newtonsoft.Json;
using LibraryAmoCRM.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Models.Fields
{
    public class MainContactField : IHaveIdSingle
    {
        [JsonProperty(PropertyName = "id")]
        public Int32? Id { get; set; }
    }
}
