using System;

namespace LibraryAmoCRM.Interfaces
{
    public interface IEntity : IElement
    {
        int ResponsibleUserId { get; set; }
        int CreatedBy { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
        int AccountId { get; set; }
        int GroupId { get; set; }
    }
}
