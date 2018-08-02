using Newtonsoft.Json;
using ServiceLibraryAmoCRM.Infarstructure;
using ServiceLibraryAmoCRM.Infarstructure.JsonConverters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLibraryAmoCRM.Models
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
