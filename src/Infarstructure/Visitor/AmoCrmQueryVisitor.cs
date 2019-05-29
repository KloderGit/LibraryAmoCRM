using LibraryAmoCRM.Infarstructure.Attributes;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace LibraryAmoCRM.Infarstructure.Visitor
{
    public class AmoCrmQueryVisitor : ExpressionVisitor
    {
        public HashSet<KeyValuePair<string, string>> Pairs { get; } = new HashSet<KeyValuePair<string, string>>();

        public Expression Apply(Expression expression)
        {
            return Visit(expression);
        }

        protected override Expression VisitBinary(BinaryExpression node)
        {
            if (node.NodeType == ExpressionType.Equal)
            {
                var left = this.Visit(node.Left);
                var right = this.Visit(node.Right);

                var leftToString = left.Type.GetMethods().FirstOrDefault(s => s.Name == "ToString");
                var name = Expression.Call(left, leftToString);

                var rightToString = right.Type.GetMethods().FirstOrDefault(s => s.Name == "ToString");
                var value = Expression.Call(right, rightToString);

                var div = Expression.Constant("=");
                var array = Expression.NewArrayInit(typeof(string), new[] { name, value });

                var method = typeof(string).GetMethod("Join", new[] { typeof(string), typeof(string[]) });

                Expression call = Expression.Call(method, div, array);

                Pairs.Add(new KeyValuePair<string, string>(left.ToString(), right.ToString()));

                return call;
            }

            if (node.NodeType == ExpressionType.AndAlso)
            {
                var left = this.Visit(node.Left);
                var right = this.Visit(node.Right);

                var div = Expression.Constant("&");
                var array = Expression.NewArrayInit(typeof(string), new[] { left, right });

                var method = typeof(string).GetMethod("Join", new[] { typeof(string), typeof(string[]) });

                Expression call = Expression.Call(method, div, array);

                return call;

            }

            return base.VisitBinary(node);
        }


        protected override Expression VisitLambda<T>(Expression<T> node)
        {
            var body = Visit(node.Body);


            var methodInfo = typeof(string).GetMethod("Concat", new[] { typeof(string), typeof(string) });
            Expression call = Expression.Call(methodInfo, Expression.Constant("?"), body);

            return Expression.Lambda(call);
        }



        protected override Expression VisitMember(MemberExpression node)
        {
            var expression = Visit(node.Expression);

            if (expression.NodeType == ExpressionType.Parameter)
            {
                var title = node.Member.GetCustomAttributes(typeof(QueryParamNameAttribute), false).First() as QueryParamNameAttribute;
                return Expression.Constant(title.Name); 
            }

            if (expression.NodeType == ExpressionType.Constant)
            {
                var result = VisitConstant(node.Expression, node.Member);

                return result;
            }

            return base.VisitMember(node);
        }

        protected Expression VisitConstant(Expression node, MemberInfo member)
        {
            ConstantExpression result = null;

            if (node.Type.IsClass)
            {
                object container = ((ConstantExpression)node).Value;

                if (member is FieldInfo)
                {
                    object value = ((FieldInfo)member).GetValue(container);
                    result = Expression.Constant(value);
                }
                if (member is PropertyInfo)
                {
                    object value = ((PropertyInfo)member).GetValue(container, null);
                    result = Expression.Constant(value);
                }
            }

            return result ?? node;
        }
    }   
}
