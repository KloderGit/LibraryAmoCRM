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
            if (node.NodeType == ExpressionType.Equal)
            {
                var left = (MemberExpression)node.Left;
                var title = left.Member.GetCustomAttributes(typeof(QueryParamNameAttribute), false).First() as QueryParamNameAttribute;

                var right = (ConstantExpression)node.Right;

                Pairs.Add(new KeyValuePair<string, string>(title.Name, right.Value.ToString()));
            }

            return base.VisitBinary(node);
        }
    }
}
