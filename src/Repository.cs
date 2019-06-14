using LibraryAmoCRM.Configuration;
using LibraryAmoCRM.Infarstructure;
using LibraryAmoCRM.Infarstructure.Visitor;
using LibraryAmoCRM.Interfaces;
using LibraryAmoCRM.Misc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.Http;
using System.Threading.Tasks;

namespace LibraryAmoCRM
{
    public class Repository<T>: IRepository<T> where T : IEntity
    {
        IConnection connection = null;
      
        public Repository(IConnection connection) => this.connection = connection;

        public Task<T> Add(T item)
        {
            throw new NotImplementedException();
        }

        #region IQueryableRepository implementation

        public Expression Expression { get; set; } = null;

        public IQueryableRepository<T> CreateQuery(Expression expression)
        {
            if (expression is LambdaExpression && Expression != null)
            {
                var current = ((LambdaExpression)Expression).Body;
                var additional = ((LambdaExpression)expression).Body;
                var extend = Expression.AndAlso(current, additional);
                Expression = Expression.Lambda(extend);
            }

            if (Expression == null) Expression = expression;

            return this;
        }

        public TResult Execute<TResult>()
        {
            connection.Auth(null);

            var endpoint = connection.GetEndPoint<T>();
            var query = BuildQueryParams();
            var request = connection.Client.GetAsync(endpoint + query).Result;

            var dtoType = MatchingDTO.GetDTOType<T>();
            var response = request.Content.ReadAsAsync(dtoType, new MediaTypesFormatters().GetHALFormatter()).Result;

            dynamic convert = Convert.ChangeType(response, dtoType);
            var result = convert?._embedded.items;

            this.Expression = null;

            return (TResult)result;
        }

        private string BuildQueryParams()
        {
            if (Expression == null) return "";

            var visitor = new AmoCrmQueryVisitor();

            var func = (visitor.Apply(Expression) as Expression<Func<string>>).Compile();

            return func();
        }
        #endregion

        #region IEnumerable implementation
        public IEnumerator<T> GetEnumerator()
        {
            var result = Execute<IEnumerable<T>>() ?? new List<T>();
            return result.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
    }
}
