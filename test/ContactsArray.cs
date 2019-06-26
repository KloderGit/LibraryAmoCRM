using LibraryAmoCRM.Models;
using System;
using System.Collections.Generic;

namespace LibraryAmoCRMTests
{
    public static class ContactsArray
    {
        public static IEnumerable<Contact> GetContacts()
        {

            IEnumerable<Contact> contacts = new List<Contact>
            {
                new Contact
                {
                    Id = 29127849,
                    AccountId = 17769199,
                    ClosestTaskAt = DateTime.MinValue,
                    CreatedAt = new DateTime(2015, 6, 20),
                    CreatedBy = 2997712,
                    GroupId = 212704,
                    ResponsibleUserId = 2997712,
                    UpdatedBy = 2079718,
                    Name = "Иджян Илья",
                    UpdatedAt = new DateTime(2017, 3, 15),
                    Company = new SimpleObject { Id = 18029551, Name = "ООО \"Фитнес Смайл\"" },
                    Leads = new List<int> { 12927239, 888888 },
                    Tags = new List<SimpleObject> { new SimpleObject { Id = 246241, Name = "new tag" }, new SimpleObject { Id = 247981, Name = "Акция" } },
                    CustomFields = new List<CustomField> {
                            new CustomField {
                                Id = 72337,
                                Name ="Город",
                                IsSystem = false,
                                Values = new List<CustomFieldValue>{ new CustomFieldValue {Value = "Москва" } }
                            },
                            new CustomField {
                                Id = 571611,
                                Name ="Guid",
                                IsSystem = false,
                                Values = new List<CustomFieldValue>{ new CustomFieldValue {Value = "c41cb2da-8977-11e6-8102-10c37b94684b" } }
                            },
                            new CustomField {
                                Id = 54669,
                                Name ="Email",
                                Code = "EMAIL",
                                IsSystem = true,
                                Values = new List<CustomFieldValue>{ new CustomFieldValue { Enum = 114619, Value = "kloder3@gmail.com" } }
                            },
                            new CustomField {
                                Id = 54667,
                                Name ="Телефон",
                                Code = "PHONE",
                                IsSystem = true,
                                Values = new List<CustomFieldValue>{ new CustomFieldValue { Enum = 114607, Value = "89031453412" } }
                            }
                        },
                    Customers = new List<int> { 321, 654, 987 }
                },
                new Contact
                {
                    Id = 24619689,
                    AccountId = 17769199,
                    ClosestTaskAt = new DateTime(2016, 4, 10),
                    CreatedAt = new DateTime(2015, 8, 3),
                    CreatedBy = 2079718,
                    GroupId = 212704,
                    ResponsibleUserId = 2079718,
                    UpdatedBy = 2079718,
                    Name = "Стуков Валериан",
                    UpdatedAt = new DateTime(2017, 10, 1),
                    CustomFields = new List<CustomField> {
                            new CustomField {
                                Id = 54667,
                                Name ="Телефон",
                                Code = "PHONE",
                                IsSystem = true,
                                Values = new List<CustomFieldValue>{ new CustomFieldValue { Enum = 114607, Value = "4985557878" } }
                            },
                            new CustomField {
                                Id = 565515,
                                Name ="Дата рождения",
                                IsSystem = false,
                                Values = new List<CustomFieldValue>{ new CustomFieldValue {Value = "2018-08-30 00:00:00" } }
                            },
                            new CustomField {
                                Id = 548465,
                                Name ="Откуда узнал о FPA",
                                IsSystem = false,
                                Values = new List<CustomFieldValue>{
                                    new CustomFieldValue { Enum = 1143911, Value = "По рекомендации" },
                                    new CustomFieldValue { Enum = 1143915, Value = "Из рекламы" },
                                    new CustomFieldValue { Enum = 1143919, Value = "Другое" }
                                }
                            }
                        }
                },
                new Contact
                {
                    Id = 27074731,
                    AccountId = 17769199,
                    ClosestTaskAt = DateTime.MinValue,
                    CreatedAt = new DateTime(2015, 9, 8),
                    CreatedBy = 0,
                    GroupId = 212704,
                    ResponsibleUserId = 2079676,
                    UpdatedBy = 2079676,
                    Name = "ТЕстовое Фл",
                    UpdatedAt = new DateTime(2017, 5, 2),
                    CustomFields = new List<CustomField> {
                            new CustomField {
                                Id = 54667,
                                Name ="Телефон",
                                Code = "PHONE",
                                IsSystem = true,
                                Values = new List<CustomFieldValue>{ new CustomFieldValue { Enum = 114607, Value = "4985557878" } }
                            },
                            new CustomField {
                                Id = 54669,
                                Name ="Email",
                                Code = "EMAIL",
                                IsSystem = true,
                                Values = new List<CustomFieldValue>{ new CustomFieldValue { Enum = 114619, Value = "site7@test.ru" } }
                            }
                        }
                }
            };

            return contacts;
        }
    }
}
