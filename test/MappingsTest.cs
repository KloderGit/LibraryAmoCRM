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
            new TaskMapping();
        }

        [TestMethod]
        public void FullContactToDtoTest()
        {
            var source = ContactsArray.Get().First();

            var firstValue = source.Adapt<Contact>();
            var dto = firstValue.Adapt<ContactDTO>();
            var secondValue = dto.Adapt<Contact>();

            var firstJson = JsonConvert.SerializeObject(firstValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            var secondjson = JsonConvert.SerializeObject(secondValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            Assert.AreNotEqual(secondValue.Id, 0);
            Assert.AreEqual(firstJson, secondjson);
        }

        [TestMethod]
        public void FullDtoToContactTest()
        {
            var firstValue = ContactsArray.Get().First();
            var entity = firstValue.Adapt<Contact>();
            var secondValue = entity.Adapt<ContactDTO>();

            var firstJson = JsonConvert.SerializeObject(firstValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            var secondjson = JsonConvert.SerializeObject(secondValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            Assert.AreNotEqual(secondValue.id, 0);
            Assert.AreEqual(firstJson, secondjson);
        }

        [TestMethod]
        public void MinContactToDtoTest()
        {
            var firstValue = new Contact { Id = 123 };
            var dto = firstValue.Adapt<ContactDTO>();
            var secondValue = dto.Adapt<Contact>();

            var firstJson = JsonConvert.SerializeObject(firstValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            var secondjson = JsonConvert.SerializeObject(secondValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            Assert.AreNotEqual(secondValue.Id, 0);
            Assert.AreEqual(firstJson, secondjson);
        }

        [TestMethod]
        public void MinDtoToContactTest()
        {
            var firstValue = new ContactDTO { id = 123 };
            var entity = firstValue.Adapt<Contact>();
            var secondValue = entity.Adapt<ContactDTO>();

            var firstJson = JsonConvert.SerializeObject(firstValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            var secondjson = JsonConvert.SerializeObject(secondValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            Assert.AreNotEqual(secondValue.id, 0);
            Assert.AreEqual(firstJson, secondjson);
        }



        [TestMethod]
        public void FullCompanyToDtoTest()
        {
            var source = CompaniesArray.GetCompaniesDto().First();

            var firstValue = source.Adapt<Company>();
            var dto = firstValue.Adapt<CompanyDTO>();
            var secondValue = dto.Adapt<Company>();

            var firstJson = JsonConvert.SerializeObject(firstValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            var secondjson = JsonConvert.SerializeObject(secondValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            Assert.AreNotEqual(secondValue.Id, 0);
            Assert.AreEqual(firstJson, secondjson);
        }

        [TestMethod]
        public void FullDtoToCompanyTest()
        {
            var firstValue = CompaniesArray.GetCompaniesDto().First();
            var entity = firstValue.Adapt<Company>();
            var secondValue = entity.Adapt<CompanyDTO>();

            var firstJson = JsonConvert.SerializeObject(firstValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            var secondjson = JsonConvert.SerializeObject(secondValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            Assert.AreNotEqual(secondValue.id, 0);
            Assert.AreEqual(firstJson, secondjson);
        }

        [TestMethod]
        public void MinCompanyToDtoTest()
        {
            var firstValue = new Company { Id = 123 };
            var dto = firstValue.Adapt<CompanyDTO>();
            var secondValue = dto.Adapt<Company>();

            var firstJson = JsonConvert.SerializeObject(firstValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            var secondjson = JsonConvert.SerializeObject(secondValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            Assert.AreNotEqual(secondValue.Id, 0);
            Assert.AreEqual(firstJson, secondjson);
        }

        [TestMethod]
        public void MinDtoToCompanyTest()
        {
            var firstValue = new CompanyDTO { id = 123 };
            var entity = firstValue.Adapt<Company>();
            var secondValue = entity.Adapt<CompanyDTO>();

            var firstJson = JsonConvert.SerializeObject(firstValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            var secondjson = JsonConvert.SerializeObject(secondValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            Assert.AreNotEqual(secondValue.id, 0);
            Assert.AreEqual(firstJson, secondjson);
        }



        [TestMethod]
        public void FullLeadToDtoTest()
        {
            var source = LeadArray.GetLeadDTO().First();

            var firstValue = source.Adapt<Lead>();
            var dto = firstValue.Adapt<LeadDTO>();
            var secondValue = dto.Adapt<Lead>();

            var firstJson = JsonConvert.SerializeObject(firstValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            var secondjson = JsonConvert.SerializeObject(secondValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            Assert.AreNotEqual(secondValue.Id, 0);
            Assert.AreEqual(firstJson, secondjson);
        }

        [TestMethod]
        public void FullDtoToLeadTest()
        {
            var firstValue = LeadArray.GetLeadDTO().First();
            var entity = firstValue.Adapt<Lead>();
            var secondValue = entity.Adapt<LeadDTO>();

            var firstJson = JsonConvert.SerializeObject(firstValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            var secondjson = JsonConvert.SerializeObject(secondValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            Assert.AreNotEqual(secondValue.id, 0);
            Assert.AreEqual(firstJson, secondjson);
        }

        [TestMethod]
        public void MinLeadToDtoTest()
        {
            var firstValue = new Lead { Id = 123 };
            var dto = firstValue.Adapt<LeadDTO>();
            var secondValue = dto.Adapt<Lead>();

            var firstJson = JsonConvert.SerializeObject(firstValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            var secondjson = JsonConvert.SerializeObject(secondValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            Assert.AreNotEqual(secondValue.Id, 0);
            Assert.AreEqual(firstJson, secondjson);
        }

        [TestMethod]
        public void MinDtoToLeadTest()
        {
            var firstValue = new LeadDTO { id = 123 };
            var entity = firstValue.Adapt<Lead>();
            var secondValue = entity.Adapt<LeadDTO>();

            var firstJson = JsonConvert.SerializeObject(firstValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            var secondjson = JsonConvert.SerializeObject(secondValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            Assert.AreNotEqual(secondValue.id, 0);
            Assert.AreEqual(firstJson, secondjson);
        }



        [TestMethod]
        public void FullNoteToDtoTest()
        {
            var source = NoteArray.GetNoteDTOs().First();

            var firstValue = source.Adapt<Note>();
            var dto = firstValue.Adapt<NoteDTO>();
            var secondValue = dto.Adapt<Note>();

            var firstJson = JsonConvert.SerializeObject(firstValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            var secondjson = JsonConvert.SerializeObject(secondValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            Assert.AreNotEqual(secondValue.Id, 0);
            Assert.AreEqual(firstJson, secondjson);
        }

        [TestMethod]
        public void FullDtoToNoteTest()
        {
            var firstValue = NoteArray.GetNoteDTOs().First();
            var entity = firstValue.Adapt<Note>();
            var secondValue = entity.Adapt<NoteDTO>();

            var firstJson = JsonConvert.SerializeObject(firstValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            var secondjson = JsonConvert.SerializeObject(secondValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            Assert.AreNotEqual(secondValue.id, 0);
            Assert.AreEqual(firstJson, secondjson);
        }

        [TestMethod]
        public void MinNoteToDtoTest()
        {
            var firstValue = new Note { Id = 123 };
            var dto = firstValue.Adapt<NoteDTO>();
            var secondValue = dto.Adapt<Note>();

            var firstJson = JsonConvert.SerializeObject(firstValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            var secondjson = JsonConvert.SerializeObject(secondValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            Assert.AreNotEqual(secondValue.Id, 0);
            Assert.AreEqual(firstJson, secondjson);
        }

        [TestMethod]
        public void MinDtoToNoteTest()
        {
            var firstValue = new NoteDTO { id = 123 };
            var entity = firstValue.Adapt<Note>();
            var secondValue = entity.Adapt<NoteDTO>();

            var firstJson = JsonConvert.SerializeObject(firstValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            var secondjson = JsonConvert.SerializeObject(secondValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            Assert.AreNotEqual(secondValue.id, 0);
            Assert.AreEqual(firstJson, secondjson);
        }



        [TestMethod]
        public void FullTaskToDtoTest()
        {
            var source = TaskArray.GetTaskDTOs().First();

            var firstValue = source.Adapt<Task>();
            var dto = firstValue.Adapt<TaskDTO>();
            var secondValue = dto.Adapt<Task>();

            var firstJson = JsonConvert.SerializeObject(firstValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            var secondjson = JsonConvert.SerializeObject(secondValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            Assert.AreNotEqual(secondValue.Id, 0);
            Assert.AreEqual(firstJson, secondjson);
        }

        [TestMethod]
        public void FullDtoToTaskTest()
        {
            var firstValue = TaskArray.GetTaskDTOs().First();
            var entity = firstValue.Adapt<Task>();
            var secondValue = entity.Adapt<TaskDTO>();

            var firstJson = JsonConvert.SerializeObject(firstValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            var secondjson = JsonConvert.SerializeObject(secondValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            Assert.AreNotEqual(secondValue.id, 0);
            Assert.AreEqual(firstJson, secondjson);
        }

        [TestMethod]
        public void MinTaskToDtoTest()
        {
            var firstValue = new Task { Id = 123 };
            var dto = firstValue.Adapt<TaskDTO>();
            var secondValue = dto.Adapt<Task>();

            var firstJson = JsonConvert.SerializeObject(firstValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            var secondjson = JsonConvert.SerializeObject(secondValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            Assert.AreNotEqual(secondValue.Id, 0);
            Assert.AreEqual(firstJson, secondjson);
        }

        [TestMethod]
        public void MinDtoToTaskTest()
        {
            var firstValue = new TaskDTO { id = 123 };
            var entity = firstValue.Adapt<Task>();
            var secondValue = entity.Adapt<TaskDTO>();

            var firstJson = JsonConvert.SerializeObject(firstValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            var secondjson = JsonConvert.SerializeObject(secondValue, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            Assert.AreNotEqual(secondValue.id, 0);
            Assert.AreEqual(firstJson, secondjson);
        }
    }

}
