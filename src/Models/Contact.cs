using LibraryAmoCRM.Interfaces.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Models
{
    public class Contact : IContact
    {
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

        // IBindLeads
        public IArrayId Leads { get; set; }

        public IEnumerable<ILead> GetLeads()
        {
            throw new NotImplementedException();
        }

        // IBindCompany
        public ICompany Company { get; set; }
    }
}
