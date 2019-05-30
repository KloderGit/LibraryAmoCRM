using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Interfaces.Entity
{
    public interface IBindContacts
    {
        IArrayId Contacts { get; set; }
        IEnumerable<IContact> GetContacts();
    }
}
