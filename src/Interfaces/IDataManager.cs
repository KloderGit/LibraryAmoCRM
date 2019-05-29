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
        Account Account { get; set; }

        IRepository<LeadDTO> Leads { get;}
        IRepository<ContactDTO> Contacts { get; }
        IRepository<CompanyDTO> Companies { get; }
        IRepository<TaskDTO> Tasks { get; }
        IRepository<NoteDTO> Notes { get; }
        IRepository<CatalogDTO> Catalogs { get; }
        FieldsRepository Fields { get; }
    }
}
