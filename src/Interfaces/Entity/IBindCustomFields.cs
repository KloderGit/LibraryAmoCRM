using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Interfaces.Entity
{
    public interface IBindCustomFields
    {
        IEnumerable<ICustomField> CustomFields { get; set; }
    }
}
