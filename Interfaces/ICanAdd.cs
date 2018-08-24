using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Interfaces
{
    public interface ICanAdd <T> where T: class
    {
        IEnumerable<T> Add(T item);
    }
}
