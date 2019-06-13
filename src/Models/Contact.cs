using LibraryAmoCRM.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Models
{
    public class Contact : IContact
    {
        public DateTime ClosestTaskAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int UpdatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEnumerable<int> Leads { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEnumerable<int> Customers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ResponsibleUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime UpdatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int AccountId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int GroupId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEnumerable<ICustomField> CustomFields { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEnumerable<ISimpleObject> Tags { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ISimpleObject Company { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
