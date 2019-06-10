using LibraryAmoCRM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Interfaces.Entity
{
    public interface IClient : IElement, ISimpleObject, IBindTags, IBindCustomFields, IBindLeads
    {
        /// <summary>
        /// Дата ближайшей задачи
        /// </summary>
        DateTime ClosestTaskAt { get; set; }

        int UpdatedBy { get; set; }
    }

}
