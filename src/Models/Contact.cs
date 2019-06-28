using LibraryAmoCRM.DTO;
using LibraryAmoCRM.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Models
{
    public class Contact : IContact
    {
        public int Id { get; set; }
        public DateTime ClosestTaskAt { get; set; }
        public int UpdatedBy { get; set; }
        public int ResponsibleUserId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int AccountId { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public IEnumerable<int> Leads { get; set; } = new List<int>();
        public IEnumerable<int> Customers { get; set; } = new List<int>();
        public IEnumerable<ISimpleObject> Tags { get; set; } = new List<ISimpleObject>();
        public IEnumerable<ICustomField> CustomFields { get; set; } = new List<ICustomField>();
        public ISimpleObject Company { get; set; }    }
}
