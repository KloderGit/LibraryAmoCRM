using LibraryAmoCRM.DTO;
using LibraryAmoCRM.Infarstructure;
using LibraryAmoCRM.Infarstructure.Visitor;
using LibraryAmoCRM.Interfaces;
using LibraryAmoCRM.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;

namespace LibraryAmoCRM.Implements
{
    public class Repository<T>: IQueryableRepository<T>
    {
        IConnection connection = null;

        IEnumerable<T> array = new List<T>();
        
        public Repository(IConnection connection) => this.connection = connection;




        public Task<T> Add(T item)
        {
            throw new NotImplementedException();
        }




        #region IQueryableRepository implementation
        // --------------------------------

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
            var endpoint = connection.GetEndPoint<T>();
            var query = BuildQueryParams();

            connection.Auth(null);

            var request = connection.Client.GetAsync(endpoint + query).Result;


            var response = request.Content.ReadAsAsync(typeof(HAL<ContactDTO>), new MediaTypesFormatters().GetHALFormatter()).Result;

            var result = ((HAL<ContactDTO>)response)?._embedded.items;

            //this.array = result;

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


        public IEnumerator<T> GetEnumerator()
        {
            if (this.array.Count() > 0) return this.array.GetEnumerator();
            var result = Execute<IEnumerable<T>>() ?? new List<T>();
            return result.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        void GetMethod(HttpResponseMessage httpResponse)
        {
            var getMethod = typeof(HttpContentExtensions).GetMethods(BindingFlags.Public);
            //MethodInfo getMethod = typeof(System.Net.Http.HttpContentExtensions).GetMethod("ReadAsAsync", BindingFlags.Public);
            //MethodInfo genericGet = getMethod.MakeGenericMethod(new[] { typeof(HAL<ContactDTO>) });


            //    return (T)genericGet.Invoke(Context, new object[] { id });
            //methodInfo = methodInfo.MakeGenericMethod(typs);

            //var parameters = methodInfo.GetParameters();
        }

        public MethodInfo GetMethodWithLinq(Type staticType, string methodName,
    params Type[] paramTypes)
        {
            var methods = from method in staticType.GetMethods()
                          where method.Name == methodName
                                && method.GetParameters()
                                         .Select(parameter => parameter.ParameterType)
                                         .Select(type => type.IsGenericType ?
                                             type.GetGenericTypeDefinition() : type)
                                         .SequenceEqual(paramTypes)
                          select method;
            try
            {
                return methods.SingleOrDefault();
            }
            catch (InvalidOperationException)
            {
                throw new AmbiguousMatchException();
            }
        }

    }
}
