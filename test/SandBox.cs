using LibraryAmoCRM;
using LibraryAmoCRM.DTO;
using LibraryAmoCRM.Infarstructure.Extensions;
using LibraryAmoCRM.Infarstructure.QueryParams;
using LibraryAmoCRM.Mappings;
using LibraryAmoCRM.Models;
using Mapster;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryAmoCRMTests
{
    [TestClass]
    public class SandBox
    {
        [TestMethod]
        public void NewModel()
        {
            //var conn = new Connection("apfitness", "kloder@fitness-pro.ru", "99aad176302f7ea9213c307e1e6ab8fc");
            //var resit = new Repository<Contact>(conn);
            //var ttt = resit.Filter<Contact, ContactFilter>(x => x.Query == "9031453412");
            //var dfg = ttt.Execute<IEnumerable<ContactDTO>>();

            //var rrr = dfg.First();

            var adapt = new ContactToDto();

            var conta = new Contact {
                Id = 234,
                Name = "Lkjldkjsfd",
                UpdatedAt = DateTime.Now,
                Tags = new List<SimpleObject> { new SimpleObject { Id = 11, Name = "NN" }, new SimpleObject { Id = 22, Name = "OO" } }
            };

            var poi = conta.Adapt<ContactDTO>();

        }
    }
}
