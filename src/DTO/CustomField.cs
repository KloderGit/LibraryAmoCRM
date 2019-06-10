using System.Collections.Generic;

namespace LibraryAmoCRM.DTO
{
    public class CustomField : EntityDTO
    {
        public string code { get; set; }
        public bool is_system { get; set; }
        public IEnumerable<CustomFieldValue> values { get; set; }
    }

    public class CustomFieldValue
    {
        public string value { get; set; }
        public string @enum { get; set; }
    }
}
