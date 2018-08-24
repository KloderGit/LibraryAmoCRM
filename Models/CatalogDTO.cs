using LibraryAmoCRM.Infarstructure.JsonConverters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace LibraryAmoCRM.Models
{
    public class CatalogDTO : CoreDTO
    {

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "catalog_id")]
        public Int32? CatalogId { get; set; }

        [JsonProperty(PropertyName = "is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty(PropertyName = "custom_fields")]
        [JsonConverter(typeof(SingleOrArrayToArrayConverter<CustomField>))]
        public IEnumerable<CustomField> CustomFields { get; set; }
    }
}
