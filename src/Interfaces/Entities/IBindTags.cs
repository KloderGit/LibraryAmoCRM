using System.Collections.Generic;

namespace LibraryAmoCRM.Interfaces
{
    public interface IBindTags
    {
        IEnumerable<ISimpleObject> Tags { get; set; }
    }
}
