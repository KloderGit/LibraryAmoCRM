using LibraryAmoCRM.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Models
{
    public class Lead : ILead
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MainContactId { get; set; }
        public DateTime NearestTaskAt { get; set; }
        public DateTime ClosedAt { get; set; }
        public bool? IsDeleted { get; set; }
        public int Status { get; set; }
        public int Price { get; set; }
        public int LossReason { get; set; }
        public int Pipeline { get; set; }
        public int ResponsibleUserId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int AccountId { get; set; }
        public int GroupId { get; set; }
        public IEnumerable<ISimpleObject> Tags { get; set; }
        public IEnumerable<ICustomField> CustomFields { get; set; }
        public IEnumerable<int> Contacts { get; set; }
        public ISimpleObject Company { get; set; }
    }
}
