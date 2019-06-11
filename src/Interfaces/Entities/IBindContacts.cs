using System.Collections.Generic;

namespace LibraryAmoCRM.Interfaces
{
    public interface IBindContacts
    {
        IEnumerable<int> Contacts { get; set; }
        IEnumerable<IContact> GetContacts();
    }
}
