using LibraryAmoCRM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Interfaces.Entity
{
    public interface IBindLeads
    {
        IArrayId Leads { get; set; }
        IEnumerable<ILead> GetLeads();
    }

}
