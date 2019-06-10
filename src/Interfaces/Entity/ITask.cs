using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Interfaces.Entity
{
    public interface ITask : IElement, IBelong
    {
        string Text { get; set; }

        int Duration { get; set; }

        bool IsCompleted { get; set; }

        DateTime CompleteTillAt { get; set; }

        //ResultField Result { get; set; }

        int TaskType { get; set; }
    }
}
