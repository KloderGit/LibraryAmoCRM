using LibraryAmoCRM.DTO;
using LibraryAmoCRM.Mappings;
using LibraryAmoCRM.Models;
using Mapster;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryAmoCRMTests
{
    [TestClass]
    public class MappingsTest
    {
        public MappingsTest()
        {
            new CommonMapping();
            new ContactMapping();
        }

        [TestMethod]
        public void ContactToDtoTest()
        {
            var contactSource = ContactsArray.GetContacts().First();
            var contactToFullDto = contactSource.Adapt<ContactDTO>();
            var DtoToContact = contactToFullDto.Adapt<Contact>();

            var v1 = JsonConvert.SerializeObject(contactSource, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            var v2 = JsonConvert.SerializeObject(DtoToContact, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            Assert.AreEqual(v1, v2);

            var d1 = JsonConvert.SerializeObject(contactSource, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            var d2 = JsonConvert.SerializeObject(DtoToContact, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            Assert.AreEqual(d1, d2);
        }

        [TestMethod]
        public void DtoToContactTest()
        {
            var contactSource = ContactsArray.GetContacts().First();

            var firstDto = contactSource.Adapt<ContactDTO>();
            var toContact = firstDto.Adapt<Contact>();
            var secondDto = toContact.Adapt<ContactDTO>();

            var firstDtoToJsonString = JsonConvert.SerializeObject(firstDto, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            var secondDtoToJsonString = JsonConvert.SerializeObject(secondDto, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            Assert.AreEqual(firstDtoToJsonString, secondDtoToJsonString);
        }
    }

}
