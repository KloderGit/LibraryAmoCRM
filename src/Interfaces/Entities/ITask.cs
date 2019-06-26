using System;

namespace LibraryAmoCRM.Interfaces
{
    public interface ITask : IEntity, IToDoObject, IBelong
    {
        bool IsCompleted { get; set; }
        DateTime CompleteTillAt { get; set; }
        IToDoObject Result { get; set; }
        int TaskType { get; set; }
    }
}