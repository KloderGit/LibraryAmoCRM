using Newtonsoft.Json;
using ServiceLibraryAmoCRM.Infarstructure.JsonConverters;
using System;
using System.Collections.Generic;

namespace ServiceLibraryAmoCRM.Models
{
    public abstract class BasicMemberEntity : CoreDTO
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonConverter(typeof(UnixTimeStampToDateTime))]
        [JsonProperty(PropertyName = "closest_task_at")]
        public DateTime? ClosestTaskAt { get; set; }

        [JsonProperty(PropertyName = "tags")]
        [JsonConverter(typeof(TagFieldSerializeConverter))]
        public IEnumerable<TagsField> Tags { get; set; }

        [JsonProperty(PropertyName = "custom_fields")]
        [JsonConverter(typeof(SingleOrArrayToArrayConverter<CustomField>))]
        public IEnumerable<CustomField> CustomFields { get; set; }
    }
}
