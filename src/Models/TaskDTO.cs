using Newtonsoft.Json;
using LibraryAmoCRM.Infarstructure;
using LibraryAmoCRM.Infarstructure.JsonConverters;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Models
{
    public class TaskDTO : BasicServiceEntity
    {
        [JsonProperty(PropertyName = "is_completed")]
        public bool? IsCompleted { get; set; }

        [JsonConverter(typeof(UnixTimeStampToDateTime))]
        [JsonProperty(PropertyName = "complete_till_at")]
        public DateTime? CompleteTillAt { get; set; }

        [JsonProperty(PropertyName = "result")]
        [JsonConverter(typeof(SingleOrArrayToValueConverter<ResultField>))]
        public ResultField Result { get; set; }

        [JsonProperty(PropertyName = "task_type")]
        public int? TaskType { get; set; }
    }
}
