using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLibraryAmoCRM.Models
{
    public class CustomField : CommonFields
    {
        [JsonProperty(PropertyName = "values")]
        public IEnumerable<CustomFieldValue> Values { get; set; }

        [JsonProperty(PropertyName = "is_system")]
        public bool? IsSystem { get; set; }
    }

    public class CustomFieldValue
    {
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        [JsonProperty(PropertyName = "enum")]
        public Int32? @Enum { get; set; }
    }
}
