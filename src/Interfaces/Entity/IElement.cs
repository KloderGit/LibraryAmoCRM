using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Interfaces.Entity
{
    public interface IElement : IEntity
    {
        int ResponsibleUserId { get; set; }
        int CreatedBy { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
        int AccountId { get; set; }
        int GroupId { get; set; }
    }
}
