using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Interfaces.Entity
{
    public interface IArrayId
    {
        IEnumerable<int> Id { get; set; }
    }
}
