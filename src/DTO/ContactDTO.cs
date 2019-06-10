using LibraryAmoCRM.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace LibraryAmoCRM.DTO
{
    public class ContactDTO : EntityDTO
    {
        public int responsible_user_id { get; set; }
        public int created_by { get; set; }
        public uint created_at { get; set; }
        public uint updated_at { get; set; }
        public int account_id { get; set; }
        public int group_id { get; set; }
        public uint closest_task_at { get; set; }
        public int updated_by { get; set; }
        [JsonConverter(typeof(ObjectOrArrayJsonConverter<EntityDTO>))] public IEnumerable<EntityDTO> tags { get; set; }
        [JsonConverter(typeof(ObjectIDToArrayJsonConverter))] public IEnumerable<int> leads { get; set; }
        [JsonConverter(typeof(SimpleObjectJsonConverter<EntityDTO>))] public EntityDTO company { get; set; }
        [JsonConverter(typeof(ObjectIDToArrayJsonConverter))] public IEnumerable<int> customers { get; set; }
        [JsonConverter(typeof(ObjectOrArrayJsonConverter<CustomField>))] public IEnumerable<CustomField> custom_fields { get; set; }
    }
}
