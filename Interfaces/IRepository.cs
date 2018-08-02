using ServiceLibraryAmoCRM.Implements;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibraryAmoCRM.Interfaces
{
    public interface IRepository<T>
    {
        IRepository<T> Get();
    }
}
