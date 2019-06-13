using LibraryAmoCRM;
using LibraryAmoCRM.Implements;
using LibraryAmoCRM.Infarstructure.Extensions;
using LibraryAmoCRM.Infarstructure.QueryParams;
using LibraryAmoCRM.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRMTests
{
    [TestClass]
    public class SandBox
    {
        [TestMethod]
        public void NewModel()
        {
                var conn = new Connection("apfitness", "kloder@fitness-pro.ru", "99aad176302f7ea9213c307e1e6ab8fc");
            //var repo = new Repository<LibraryAmoCRM.DTO.ContactDTO>(conn);

            //    var ddd = repo.Filter<LibraryAmoCRM.DTO.ContactDTO, ContactFilter>(x => x.Query == "9031453412").Result();

            //    //var llll = ddd.Execute<IEnumerable<LibraryAmoCRM.DTO.ContactDTO>>().FirstOrDefault();


            //    //var dgfkljkl = ddd.Result();

            var resit = new Repository<Contact>(conn);

            var ttt = resit.Filter<Contact, ContactFilter>(x => x.Query == "9031453412");

            ttt.Execute<Contact>();

            //    var sdgf = ttt.Execute<IEnumerable<ContactDTO>>();
        }
    }
}
