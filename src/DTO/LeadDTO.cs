using LibraryAmoCRM.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace LibraryAmoCRM.DTO
{
    internal class LeadDTO : EntityDTO
    {
        public int responsible_user_id { get; set; }
        public int created_by { get; set; }
        public uint created_at { get; set; }
        public uint updated_at { get; set; }
        public int account_id { get; set; }
        public int group_id { get; set; }
        public uint closest_task_at { get; set; }
        public bool? is_deleted { get; set; }
        public int pipeline_id { get; set; }
        public uint closed_at { get; set; }
        public int status_id { get; set; }
        public int sale { get; set; }
        public int loss_reason_id { get; set; }
        public Element pipeline { get; set; }
        public Element main_contact { get; set; }
        [JsonConverter(typeof(ObjectOrArrayJsonConverter<EntityDTO>))] public IEnumerable<EntityDTO> tags { get; set; }
        [JsonConverter(typeof(SimpleObjectJsonConverter<EntityDTO>))] public EntityDTO company { get; set; }
        [JsonConverter(typeof(ObjectOrArrayJsonConverter<CustomFieldDTO>))] public IEnumerable<CustomFieldDTO> custom_fields { get; set; }
        [JsonConverter(typeof(ObjectIDToArrayJsonConverter))] public IEnumerable<int> contacts { get; set; }
    }
}
