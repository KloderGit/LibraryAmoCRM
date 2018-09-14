using LibraryAmoCRM.Implements;
using LibraryAmoCRM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAmoCRM.Interfaces
{
    public interface ICommonRepository<T> where T : CoreDTO
    {
        CommonRepository<T> Get();
        Func<Task<IEnumerable<T>>> Execute { get; set; }
        Task<T> Add(T item);
        Task Update(T item);
    }
}
