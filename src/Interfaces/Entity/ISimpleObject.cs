using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Interfaces.Entity
{
    public interface ISimpleObject : IEntity
    {
        string Name { get; set; }
    }
}
