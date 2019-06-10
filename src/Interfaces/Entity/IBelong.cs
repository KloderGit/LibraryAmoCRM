using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Interfaces.Entity
{
    public interface IBelong
    {
        int ElementId { get; set; }

        int ElementType { get; set; }
    }
}
