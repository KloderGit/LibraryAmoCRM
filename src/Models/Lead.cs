using LibraryAmoCRM.Interfaces;
using LibraryAmoCRM.Interfaces.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Models
{
    public class Lead : ILead
    {
        public bool IsDeleted { get; set; }
        public DateTime ClosedAt { get; set; }
        public IEntity Company { get; set; }
        public IEntity MainContact { get; set; }
        public int Status { get; set; }
        public int Price { get; set; }
        public int LossReason { get; set; }
        public IEntity Pipeline { get; set; }

        // IEntity
        public int Id { get; set; }

        // IElement
        public int ResponsibleUserId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int AccountId { get; set; }
        public int GroupId { get; set; }

        // IClient
        public string Name { get; set; }
        public DateTime ClosestTaskAt { get; set; }
        public int UpdatedBy { get; set; }

        // IBindTags
        public IEnumerable<ITag> Tags { get; set; }

        // IBindCustomFields
        public IEnumerable<ICustomField> CustomFields { get; set; }

        // IBindContacts
        public IArrayId Contacts { get; set; }

        public IEnumerable<IContact> GetContacts()
        {
            throw new NotImplementedException();
        }
    }
}
