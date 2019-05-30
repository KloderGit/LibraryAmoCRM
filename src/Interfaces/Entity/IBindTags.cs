using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Interfaces.Entity
{
    public interface IBindTags
    {
        IEnumerable<ITag> Tags { get; set; }
    }
}
