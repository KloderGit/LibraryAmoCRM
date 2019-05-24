using LibraryAmoCRM.Infarstructure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

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

            string que ="";

            if (node.NodeType == ExpressionType.Equal)
            {
                var left = this.Visit(node.Left);
                var right = this.Visit(node.Right);

                que = left + " - " + right;

                //Pairs.Add(new KeyValuePair<string, string>(left.Value.ToString(), right.Value.ToString()));
            }

            if (node.NodeType == ExpressionType.AndAlso)
            {
                var left = this.Visit(node.Left);
                var right = this.Visit(node.Left);

                que = left + " | " + right;
            }

            return Expression.Constant(que);
        }


        protected override Expression VisitMember(MemberExpression node)
        {
            Expression result = this.Visit(node.Expression);

            if (result.NodeType == ExpressionType.Constant)
            {
                var value = ((ConstantExpression)result).Value;
                result = Expression.Constant(value);
            }

            if (result.NodeType == ExpressionType.Parameter)
            {
                var title = node.Member.GetCustomAttributes(typeof(QueryParamNameAttribute), false).First() as QueryParamNameAttribute;
                result = Expression.Constant(title.Name);
            }

            return result;
        }
    }
}
