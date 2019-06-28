using LibraryAmoCRM.DTO;
using LibraryAmoCRM.Mappings;
using LibraryAmoCRM.Models;
using LibraryAmoCRMTests.Data;
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
            new CompanyMapping();
            new LeadMapping();
            new NoteMapping();
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


        [TestMethod]
        public void CompanyToDtoTest()
        {
            var companySource = CompaniesArray.GetCompaniesDto().First();

            var firstValue = companySource.Adapt<Company>();
            var dto = firstValue.Adapt<CompanyDTO>();
            var secondValue = dto.Adapt<Company>();

            var firstJson = JsonConvert.SerializeObject(firstValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            var secondjson = JsonConvert.SerializeObject(secondValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            Assert.AreEqual(firstJson, secondjson);
        }

        [TestMethod]
        public void DtoToCompanyTest()
        {
            var firstValue = CompaniesArray.GetCompaniesDto().First();
            var company = firstValue.Adapt<Company>();
            var secondValue = company.Adapt<CompanyDTO>();

            var firstJson = JsonConvert.SerializeObject(firstValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            var secondjson = JsonConvert.SerializeObject(secondValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            Assert.AreEqual(firstJson, secondjson);
        }




        [TestMethod]
        public void LeadToDtoTest()
        {
            var firstDto = LeadArray.GetLeadDTO().First();

            var lead = firstDto.Adapt<Lead>();
            var toDto = lead.Adapt<LeadDTO>();
            var lead2 = toDto.Adapt<Lead>();

            var firstJson = JsonConvert.SerializeObject(lead, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            var secondjson = JsonConvert.SerializeObject(lead2, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            Assert.AreEqual(firstJson, secondjson);


        }

        [TestMethod]
        public void DtoToLeadTest()
        {
            var firstDto = LeadArray.GetLeadDTO().First();
            var lead = firstDto.Adapt<Lead>();
            var secondDto = lead.Adapt<LeadDTO>();

            var firstJson = JsonConvert.SerializeObject(firstDto, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            var secondjson = JsonConvert.SerializeObject(secondDto, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            Assert.AreEqual(firstJson, secondjson);
        }



        [TestMethod]
        public void NoteToDtoTest()
        {
            var firstDto = NoteArray.GetNoteDTOs().First();

            var note = firstDto.Adapt<Note>();
            var toDto = note.Adapt<NoteDTO>();
            var note2 = toDto.Adapt<Note>();

            var firstJson = JsonConvert.SerializeObject(note, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            var secondjson = JsonConvert.SerializeObject(note2, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            Assert.AreEqual(firstJson, secondjson);
        }

        [TestMethod]
        public void DtoToNoteTest()
        {
            var firstDto = NoteArray.GetNoteDTOs().First();
            var note = firstDto.Adapt<Note>();
            var toDto = note.Adapt<NoteDTO>();

            var firstJson = JsonConvert.SerializeObject(firstDto, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            var secondjson = JsonConvert.SerializeObject(toDto, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            Assert.AreEqual(firstJson, secondjson);

            var dd = new Note() { Id = 3, CreatedAt = new DateTime(2010, 1, 15) };
            var tt = dd.Adapt<NoteDTO>();
            var dr = tt.Adapt<Note>();
        }
    }

}
