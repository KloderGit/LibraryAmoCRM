using LibraryAmoCRM.Implements;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAmoCRM.Interfaces
{
    public interface IRepository<T>
    {
        IRepository<T> Get();
    }
}
