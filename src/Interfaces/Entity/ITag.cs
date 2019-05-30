using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Interfaces.Entity
{
    public interface ITag : IElement
    {
        string Name { get; set; }
    }
}
