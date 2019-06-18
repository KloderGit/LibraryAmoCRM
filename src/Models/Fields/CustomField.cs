using LibraryAmoCRM.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Models
{
    public class CustomField : ICustomField
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool IsSystem { get; set; }
        public IEnumerable<ICustomFieldValue> Values { get; set; }
    }

    public class CustomFieldValue : ICustomFieldValue
    {
        public string Value { get; set; }
        public int Enum { get; set; }
    }
}
