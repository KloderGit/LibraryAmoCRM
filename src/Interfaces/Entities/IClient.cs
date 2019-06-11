using System;
using System.Collections.Generic;

namespace LibraryAmoCRM.Interfaces
{
    public interface IClient : IEntity, ISimpleObject, IBindCustomFields, IBindTags
    {
        DateTime ClosestTaskAt { get; set; }
        int UpdatedBy { get; set; }
        IEnumerable<int> Leads { get; set; }
        IEnumerable<int> Customers { get; set; }
    }
}
