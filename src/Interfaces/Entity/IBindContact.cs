using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Interfaces.Entity
{
    public interface IBindContact
    {
        IArrayId Contacts { get; set; }

        IEnumerable<IContact> GetContacts();
    }
}
