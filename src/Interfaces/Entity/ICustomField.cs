using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Interfaces.Entity
{
    public interface ICustomField : IEntity
    {
        string Name { get; set; }

        string Code { get; set; }

        IEnumerable<ICustomFieldValue> Values { get; set; }

        bool IsSystem { get; set; }
    }

    public interface ICustomFieldValue
    {
        string Value { get; set; }

        Int32 @Enum { get; set; }
    }
}
