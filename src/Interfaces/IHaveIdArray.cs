using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Interfaces
{
    internal interface IHaveIdArray
    {
        IEnumerable<int> IDs { get; set; }
    }
}
