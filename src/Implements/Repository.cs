using LibraryAmoCRM.Infarstructure;
using LibraryAmoCRM.Infarstructure.Exceptions;
using LibraryAmoCRM.Infarstructure.Visitor;
using LibraryAmoCRM.Interfaces;
using LibraryAmoCRM.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Threading.Tasks;

namespace LibraryAmoCRM.Implements
{
    public class Repository<T>: IQueryableRepository<T>
    {
        IConnection connection = null;
        public Expression Expression { get; set; } = null;
        public Repository(IConnection connection) => this.connection = connection;

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



        public Task<T> Add(T item)
        {
            throw new NotImplementedException();
        }


        public TResult Execute<TResult>()
        {
            var endpoint = connection.GetEndPoint<T>();
            var query = BuildQueryParams();

            connection.Auth(null);

            var request = connection.Client.GetAsync(endpoint + query).Result;

            var response = request.Content.ReadAsAsync<HAL<T>>(new MediaTypesFormatters().GetHALFormatter()).Result;

            var result = response?._embedded.items;

            return (TResult)result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var array = Execute<IEnumerable<T>>();
            var result = array ?? new List<T>();
            return result.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private string BuildQueryParams()
        {
            var visitor = new AmoCrmQueryVisitor();

            var func = (visitor.Apply(Expression) as Expression<Func<string>>).Compile();

            return func();
        }
    }
}
