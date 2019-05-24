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
        Connection connection = null;

        public Repository(Connection connection) => this.connection = connection;

        public ICollection<Expression> Expressions { get; set; } = new List<Expression>();

        public IQueryableRepository<T> CreateQuery(Expression expression)
        {
            Expressions.Add(expression);
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

            foreach (var exp in this.Expressions)
            {
                Expression turn = visitor.Apply((Expression)exp);
            }

            this.Expressions = new List<Expression>();

            return "?" + new FormUrlEncodedContent(visitor.Pairs).ReadAsStringAsync().Result;
        }
    }
}
