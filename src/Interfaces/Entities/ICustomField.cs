using System;
using System.Collections.Generic;

namespace LibraryAmoCRM.Interfaces
{
    public interface ICustomField : ISimpleObject
    {
        string Code { get; set; }
        bool IsSystem { get; set; }
        IEnumerable<ICustomFieldValue> Values { get; set; }
    }

    public interface ICustomFieldValue
    {
        string Value { get; set; }
        Int32 @Enum { get; set; }
    }
}
