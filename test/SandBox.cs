using LibraryAmoCRM;
using LibraryAmoCRM.DTO;
using LibraryAmoCRM.Infarstructure.Extensions;
using LibraryAmoCRM.Infarstructure.QueryParams;
using LibraryAmoCRM.Interfaces;
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

            new CommonMapping();
            new ContactMapping();

            var conta = new Contact {
                Id = 234,
                AccountId = 666666666,
                ClosestTaskAt = new DateTime(2015, 12, 3),
                CreatedAt = new DateTime(2015, 6, 20),
                CreatedBy = 3654,
                Customers = new List<int> { 321, 654, 987 },
                GroupId = 786,
                ResponsibleUserId = 888765,
                UpdatedBy = 765654,
                Name = "Lkjldkjsfd",
                UpdatedAt = DateTime.Now,
                Tags = new List<SimpleObject> { new SimpleObject { Id = 11, Name = "NN" }, new SimpleObject { Id = 22, Name = "OO" } },
                CustomFields = new List<CustomField> {
                    new CustomField {
                        Id = 1,
                        Name ="Pole",
                        Code = "33",
                        IsSystem = false,
                        Values = new List<CustomFieldValue>{ new CustomFieldValue { Enum = 321, Value = "Значение" } }
                    }
                },
                Company = new SimpleObject { Id = 555, Name = "Objjjj" },
                Leads = new List<int> { 555,999,777,888 }
            };

            var poi = conta.Adapt<ContactDTO>();

        }
    }
}
