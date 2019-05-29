using LibraryAmoCRM.Models.SysModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Models
{

    public class HALSelf
    {
        [JsonProperty("_links")]
        public Links Links { get; set; }
    }

    public partial class AccountEmbedded
    {
        [JsonProperty("custom_fields")]
        public Custom CustomFields { get; set; }

        //[JsonProperty("messenger")]
        //public Messenger Messenger { get; set; }

        //[JsonProperty("notifications")]
        //public Notifications Notifications { get; set; }

        [JsonProperty("users")]
        public Dictionary<string, User> Users { get; set; }

        [JsonProperty("note_types")]
        public Dictionary<string, NoteType> NoteTypes { get; set; }

        [JsonProperty("groups")]
        public Dictionary<string, Group> Groups { get; set; }

        [JsonProperty("task_types")]
        public Dictionary<string, TaskType> TaskTypes { get; set; }

        [JsonProperty("pipelines")]
        public Dictionary<string, PipeLine> Pipelines { get; set; }
    }




    public class HAL<T> : HALSelf
    {
        public embedded<T> _embedded { get; set; }
    }
    
    public class embedded<T>
    {
        public IEnumerable<T> items { get; set; }
    }





    public partial class Links
    {
        [JsonProperty("self")]
        public Self Self { get; set; }
    }

    public partial class Self
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }
    }
}