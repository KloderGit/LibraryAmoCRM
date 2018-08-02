using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLibraryAmoCRM.Interfaces
{
    internal interface IHaveIdArray
    {
        IEnumerable<int> IDs { get; set; }
    }
}
