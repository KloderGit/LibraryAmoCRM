using LibraryAmoCRM;
using LibraryAmoCRM.Interfaces;
using LibraryAmoCRM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRMTests
{
    public class DataManagerMock : IDataManager
    {
        IRepository<Contact> contact = new Repository<Contact>(null);

        public IRepository<Contact> Contacts => throw new NotImplementedException();
    }
}
