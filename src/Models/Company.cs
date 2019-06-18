using LibraryAmoCRM.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Models
{
    public class Company : ICompany
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ClosestTaskAt { get; set; }
        public int UpdatedBy { get; set; }
        public IEnumerable<int> Leads { get; set; }
        public IEnumerable<int> Customers { get; set; }
        public int ResponsibleUserId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int AccountId { get; set; }
        public int GroupId { get; set; }
        public IEnumerable<ICustomField> CustomFields { get; set; }
        public IEnumerable<ISimpleObject> Tags { get; set; }
        public IEnumerable<int> Contacts { get; set; }
    }
}
