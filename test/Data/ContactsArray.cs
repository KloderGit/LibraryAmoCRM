using LibraryAmoCRM.DTO;
using LibraryAmoCRM.Models;
using System;
using System.Collections.Generic;

namespace LibraryAmoCRMTests
{
    public static class ContactsArray
    {
        internal static IEnumerable<ContactDTO> Get()
        {
            IEnumerable<ContactDTO> contacts = new List<ContactDTO>
            {
                new ContactDTO{
                    id = 29127849,
                    name = "Иджян Илья",
                    responsible_user_id = 2997712,
                    created_by = 2997712,
                    created_at = 1549370109,
                    updated_at = 1561730057,
                    account_id = 17769199,
                    updated_by = 2079718,
                    group_id = 212704,
                    company = new EntityDTO{ id = 33478747, name = "(АНО) «Учебно-методический центр «Профессионалы фитнеса»" },
                    leads = new List<int> { 12927239, 16238885, 16239863 },
                    closest_task_at = 0,
                    tags = new List<EntityDTO>{
                        new EntityDTO { id = 246241, name = "new tag" },
                        new EntityDTO { id = 247981, name = "Акция" },
                    },
                    custom_fields = new List<CustomFieldDTO>{
                        new CustomFieldDTO{
                            id = 72337,
                            name = "Город",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO{ value = "Москва" }
                            },
                            is_system = false
                        },
                        new CustomFieldDTO{
                            id = 571611,
                            name = "Guid",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO{ value = "c41cb2da-8977-11e6-8102-10c37b94684b" }
                            },
                            is_system = false
                        },
                        new CustomFieldDTO{
                            id = 54669,
                            name = "Email",
                            code = "EMAIL",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO{ @enum = 114619, value = "kloder3@gmail.com" }
                            },
                            is_system = true
                        },
                        new CustomFieldDTO{
                            id = 54665,
                            name = "Должность",
                            code = "POSITION",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO{ value = "разработчик" }
                            },
                            is_system = true
                        },
                        new CustomFieldDTO{
                            id = 54673,
                            name = "Мгн. сообщения",
                            code = "IM",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO{ @enum = 114625, value = "kloder1" }
                            },
                            is_system = true
                        },
                        new CustomFieldDTO{
                            id = 565515,
                            name = "Дата рождения",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO{ value = "1978-02-02 00:00:00" }
                            },
                            is_system = false
                        },
                        new CustomFieldDTO{
                            id = 565517,
                            name = "Образование",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO{ value = "Высшее" }
                            },
                            is_system = false
                        },
                        new CustomFieldDTO{
                            id = 565519,
                            name = "Опыт занятия спортом",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO{ value = "5 лет" }
                            },
                            is_system = false
                        },
                        new CustomFieldDTO{
                            id = 565521,
                            name = "№ подгруппы (по желанию)",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO{ value = "3" }
                            },
                            is_system = false
                        },
                        new CustomFieldDTO{
                            id = 565525,
                            name = "Место жительства",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO{ value = "Москва" }
                            },
                            is_system = false
                        },
                        new CustomFieldDTO{
                            id = 548465,
                            name = "Откуда узнал о FPA",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO{ @enum = 1143911, value = "По рекомендации" },
                                new CustomFieldValueDTO{ @enum = 1143913, value = "От знакомых" }
                            },
                            is_system = false
                        },
                        new CustomFieldDTO{
                            id = 54667,
                            name = "Телефон",
                            code = "PHONE",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO{ @enum = 114607, value = "79031453412" }
                            },
                            is_system = true
                        }
                    }
                },
                new ContactDTO{
                    id = 28479927,
                    name = "Мила Маминова",
                    responsible_user_id = 2079718,
                    created_by = 2079718,
                    created_at = 1547107558,
                    updated_at = 1561730121,
                    account_id = 17769199,
                    updated_by = 2079718,
                    group_id = 212704,
                    company = new EntityDTO { id = 33478747, name = "(АНО) «Учебно-методический центр «Профессионалы фитнеса»" },
                    leads = new List<int> { 12439903, 13450021, 13483921, 15935173 },
                    closest_task_at = 0,
                    custom_fields = new List<CustomFieldDTO>{
                        new CustomFieldDTO{
                            id = 571611,
                            name = "Guid",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO { value = "ce6b2cef-7536-11e8-80fc-0cc47a4b75cc" }
                            },
                            is_system = false
                        },
                        new CustomFieldDTO{
                            id = 72337,
                            name = "Город",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO { value = "Москва" }
                            },
                            is_system = false
                        },
                        new CustomFieldDTO{
                            id = 565515,
                            name = "Дата рождения",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO { value = "1994-02-07 00:00:00" }
                            },
                            is_system = false
                        },
                        new CustomFieldDTO{
                            id = 565525,
                            name = "Место жительства",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO { value = "Нет" }
                            },
                            is_system = false
                        },
                        new CustomFieldDTO{
                            id = 565517,
                            name = "Образование",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO { value = "Было" }
                            },
                            is_system = false
                        },
                        new CustomFieldDTO{
                            id = 565519,
                            name = "Опыт занятия спортом",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO { value = "Нет" }
                            },
                            is_system = false
                        },
                        new CustomFieldDTO{
                            id = 565521,
                            name = "№ подгруппы (по желанию)",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO { value = "2" }
                            },
                            is_system = false
                        },
                        new CustomFieldDTO{
                            id = 587661,
                            name = "Instagram",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO { value = "https://www.instagram.com/mila_molodec/" }
                            },
                            is_system = false
                        },
                        new CustomFieldDTO{
                            id = 54669,
                            name = "Email",
                            code = "EMAIL",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO { @enum = 114619, value = "mila.maminova@gmail.com" },
                                new CustomFieldValueDTO { @enum = 114621, value = "mila.komendantova@gmail.com" }
                            },
                            is_system = true
                        },
                        new CustomFieldDTO{
                            id = 54667,
                            name = "Телефон",
                            code = "PHONE",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO { @enum = 114611, value = "89854507947" }
                            },
                            is_system = true
                        },
                        new CustomFieldDTO{
                            id = 548465,
                            name = "Откуда узнал о FPA",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO { @enum = 1143917, value = "Интернет" }
                            },
                            is_system = false
                        }
                    }
                }
            };

            return contacts;
        }
    }
}
