using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Models.SysModels
{
    public class Field
    {
        [JsonProperty(PropertyName = "Id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "field_type")]
        public int FieldType { get; set; }

        [JsonProperty(PropertyName = "sort")]
        public int Sort { get; set; }

        [JsonProperty(PropertyName = "is_multiple")]
        public bool isMultiple { get; set; }

        [JsonProperty(PropertyName = "is_system")]
        public bool isSystem { get; set; }

        [JsonProperty(PropertyName = "is_editable")]
        public bool isEditable { get; set; }

        [JsonProperty(PropertyName = "is_required")]
        public bool isRequired { get; set; }

        [JsonProperty(PropertyName = "is_deletable")]
        public bool isDeletable { get; set; }

        [JsonProperty(PropertyName = "is_visible")]
        public bool isVisible { get; set; }

        [JsonProperty("enums", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<int, string> Enums { get; set; }
    }
}
