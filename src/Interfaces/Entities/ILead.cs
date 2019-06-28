using System;

namespace LibraryAmoCRM.Interfaces
{
    public interface ILead: IEntity, ISimpleObject, IBindTags, IBindCustomFields, IBindContacts, IBindCompany
    {
        int MainContactId { get; set; }
        DateTime NearestTaskAt { get; set; }
        DateTime ClosedAt { get; set; }
        bool? IsDeleted { get; set; }
        int Status { get; set; }
        int Price { get; set; }
        int LossReason { get; set; }
        int Pipeline { get; set; }
    }
}
