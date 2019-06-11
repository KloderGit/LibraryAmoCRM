using System.Collections.Generic;

namespace LibraryAmoCRM.Interfaces
{
    public interface IBindCustomFields
    {
        IEnumerable<ICustomField> CustomFields { get; set; }
    }
}
