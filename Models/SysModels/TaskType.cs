using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Models.SysModels
{
    public class TaskType
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
