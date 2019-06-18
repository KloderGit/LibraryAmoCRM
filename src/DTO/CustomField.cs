using System.Collections.Generic;

namespace LibraryAmoCRM.DTO
{
    internal class CustomFieldDTO : EntityDTO
    {
        public string code { get; set; }
        public bool is_system { get; set; }
        public IEnumerable<CustomFieldValueDTO> values { get; set; }
    }

    internal class CustomFieldValueDTO
    {
        public string value { get; set; }
        public string @enum { get; set; }
    }
}
