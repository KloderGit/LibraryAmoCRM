using LibraryAmoCRM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Interfaces.Entity
{
    public interface IClient : IElement, IBindTags, IBindCustomFields, IBindLeads
    {
        string Name { get; set; }

        /// <summary>
        /// Дата ближайшей задачи
        /// </summary>
        DateTime ClosestTaskAt { get; set; }

        int UpdatedBy { get; set; }
    }

}
