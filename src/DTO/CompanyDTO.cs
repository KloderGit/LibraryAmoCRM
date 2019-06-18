using LibraryAmoCRM.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace LibraryAmoCRM.DTO
{
    internal class CompanyDTO : EntityDTO
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
        [JsonConverter(typeof(ObjectOrArrayJsonConverter<CustomFieldDTO>))] public IEnumerable<CustomFieldDTO> custom_fields { get; set; }
        [JsonConverter(typeof(ObjectIDToArrayJsonConverter))] public IEnumerable<int> contacts { get; set; }
        [JsonConverter(typeof(ObjectIDToArrayJsonConverter))] public IEnumerable<int> customers { get; set; }
    }
}
