using LibraryAmoCRM.Infarstructure.QueryParams;
using LibraryAmoCRM.Infarstructure.Visitor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq.Expressions;

namespace LibraryAmoCRMTests
{
    [TestClass]
    public class QueryVisitorTest
    {
        [TestMethod]
        public void OneParamTest()
        {
            Expression<Func<ContactFilter, bool>> exp = x => x.Id == 555;

            var visitor = new AmoCrmQueryVisitor();

            var func = (visitor.Apply(exp) as Expression<Func<string>>).Compile();

            var result = func();

            Assert.AreEqual(result, "?id[]=555");
        }



        [TestMethod]
        public void AndAlsoTest()
        {
            Expression<Func<ContactFilter, bool>> exp = x => x.Id == 555 && x.LimitRows == 333;

            var visitor = new AmoCrmQueryVisitor();

            var func = (visitor.Apply(exp) as Expression<Func<string>>).Compile();

            var result = func();

            Assert.AreEqual(result, "?id[]=555&limit_rows=333");
        }


        [TestMethod]
        public void AndAlsoTreeTest()
        {
            Expression<Func<ContactFilter, bool>> expFilter1 = x => x.Id == 555 && x.LimitRows == 333;
            Expression<Func<ContactFilter, bool>> expFilter2 = x => x.Phone == "85559998448";

            var current = expFilter1.Body;
            var additional = expFilter2.Body;
            var extend = Expression.AndAlso(current, additional);

            Expression expWithTwoFilters = Expression.Lambda(extend);

            var visitor = new AmoCrmQueryVisitor();

            var func = (visitor.Apply(expWithTwoFilters) as Expression<Func<string>>).Compile();

            var result = func();

            Assert.AreEqual(result, "?id[]=555&limit_rows=333&query=85559998448");
        }
    }
}