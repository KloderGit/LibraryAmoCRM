using LibraryAmoCRM.Implements;
using LibraryAmoCRM.Models;
using LibraryAmoCRM.Models.SysModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Interfaces
{
    public interface IDataManager
    {
        //Account Account { get; set; }

        //IRepository<Lead> Leads { get;}
        IRepository<Contact> Contacts { get; }
        //IRepository<Company> Companies { get; }
        //IRepository<Task> Tasks { get; }
        //IRepository<Note> Notes { get; }
        //IRepository<Catalog> Catalogs { get; }
        //FieldsRepository Fields { get; }
    }
}
