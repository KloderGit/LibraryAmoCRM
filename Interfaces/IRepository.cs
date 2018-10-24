using LibraryAmoCRM.Implements;
using LibraryAmoCRM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAmoCRM.Interfaces
{
    public interface IRepository<T> where T : CoreDTO
    {
        IRepository<T> Get();
        Func<Task<IEnumerable<T>>> Execute { get; set; }
        Task<T> Add(T item);
        Task Update(T item);
    }
}
