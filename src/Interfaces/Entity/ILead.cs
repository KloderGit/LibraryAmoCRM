using LibraryAmoCRM.Models;
using LibraryAmoCRM.Models.Fields;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Interfaces.Entity
{
    public interface ILead: IElement, IBindTags, IBindCustomFields, IBindContacts
    {
        string Name { get; set; }

        /// <summary>
        /// Дата ближайшей задачи
        /// </summary>
        DateTime ClosestTaskAt { get; set; }

        bool IsDeleted { get; set; }

        DateTime ClosedAt { get; set; }

        IEntity Company { get; set; }

        IEntity MainContact { get; set; }

        int Status { get; set; }

        int Price { get; set; }

        int LossReason { get; set; }

        IEntity Pipeline { get; set; }
    }
}
