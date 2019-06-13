using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace LibraryAmoCRM.Interfaces
{
    public interface IQueryableRepository<T> : IRepository<T>, IEnumerable
    {
        Expression Expression { get; set; }
        IQueryableRepository<T> CreateQuery(Expression expression);
        TResult Execute<TResult>();
    }
}
