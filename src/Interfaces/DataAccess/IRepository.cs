using System.Collections;
using System.Threading.Tasks;

namespace LibraryAmoCRM.Interfaces
{
    public interface IRepository<T> : IQueryableRepository<T>, IEnumerable
    {
        Task<T> Add(T item);
    }
}
