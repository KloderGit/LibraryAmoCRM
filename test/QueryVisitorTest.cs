using LibraryAmoCRM;
using LibraryAmoCRM.Implements;
using LibraryAmoCRM.Infarstructure.QueryParams;
using LibraryAmoCRM.Infarstructure.Visitor;
using LibraryAmoCRM.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq.Expressions;
using LibraryAmoCRM.Infarstructure.Extensions;
using System.Linq;
using System.Collections.Generic;

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

        [TestMethod]
        public void NewModel()
        {
            var conn = new Connection("apfitness", "kloder@fitness-pro.ru", "99aad176302f7ea9213c307e1e6ab8fc");
            var repo = new Repository<LibraryAmoCRM.DTO.ContactDTO>(conn);

            var ddd = repo.Filter<LibraryAmoCRM.DTO.ContactDTO, ContactFilter>(x => x.Query == "9031453412");

            var llll = ddd.Execute<IEnumerable<LibraryAmoCRM.DTO.ContactDTO>>().FirstOrDefault();
        }
    }
}