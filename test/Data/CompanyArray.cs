using LibraryAmoCRM.DTO;
using System.Collections.Generic;

namespace LibraryAmoCRMTests
{
    public static class CompaniesArray
    {
        internal static IEnumerable<CompanyDTO> GetCompaniesDto()
        {
            return new List<CompanyDTO> {
                new CompanyDTO {
                    id = 33478747,
                    name = "(АНО) «Учебно-методический центр «Профессионалы фитнеса»",
                    responsible_user_id = 2079718,
                    created_by = 2079718,
                    created_at = 1561730017,
                    updated_at = 1561730122,
                    account_id = 17769199,
                    updated_by = 2079718,
                    group_id = 212704,
                    leads = new List<int>{
                        12439903, 13450021, 13483921, 15935173
                    },
                    closest_task_at = 1561755540,
                    tags = new List<EntityDTO>{
                        new EntityDTO { id = 176263, name = "callback" },
                        new EntityDTO { id = 283191, name = "FPA"}
                    },
                    custom_fields = new List<CustomFieldDTO>{
                        new CustomFieldDTO {
                            id = 54667,
                            name = "Телефон",
                            code = "PHONE",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO { @enum = 114607, value = "+7 (499) 110-68-67" }
                            },
                            is_system = true
                        },
                        new CustomFieldDTO {
                            id = 54669,
                            name = "Email",
                            code = "EMAIL",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO { @enum = 114619, value = "info@fitness-pro.ru" }
                            },
                            is_system = true
                        },
                        new CustomFieldDTO {
                            id = 72341,
                            name = "ИНН/КПП",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO { value = "7706230753/772801001" }
                            },
                            is_system = false
                        },
                        new CustomFieldDTO {
                            id = 72343,
                            name = "Расчетный счет",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO { value = "40703810638110101296" }
                            },
                            is_system = false
                        },
                        new CustomFieldDTO {
                            id = 72345,
                            name = "Наименование банка",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO { value = "ПАО «Сбербанк России» г. Москва" }
                            },
                            is_system = false
                        },
                        new CustomFieldDTO {
                            id = 72349,
                            name = "Корреспондентский счет",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO { value = "30101810400000000225" }
                            },
                            is_system = false
                        },
                        new CustomFieldDTO {
                            id = 72355,
                            name = "БИК",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO { value = "044525225" }
                            },
                            is_system = false
                        },
                        new CustomFieldDTO {
                            id = 72371,
                            name = "Должность руководителя",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO { value = "Генеральный директор" }
                            },
                            is_system = false
                        },
                        new CustomFieldDTO {
                            id = 72375,
                            name = "ФИО Руководителя",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO { value = "Калашников Д. Г." }
                            },
                            is_system = false
                        },
                        new CustomFieldDTO {
                            id = 72389,
                            name = "Действует на основании",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO { value = "Приказа" }
                            },
                            is_system = false
                        },
                        new CustomFieldDTO {
                            id = 54671,
                            name = "Web",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO { value = "https://fitness-pro.ru" }
                            },
                            is_system = true
                        },
                        new CustomFieldDTO {
                            id = 54675,
                            name = "Адрес",
                            code = "ADDRESS",
                            values = new List<CustomFieldValueDTO>{
                                new CustomFieldValueDTO { value = @"107023 г. Москва, ул. Малая Семеновская, дом 9, бизнес-центр ""На Семеновской"", строение 9" }
                            },
                            is_system = true
                        }
                    },
                    contacts = new List<int>{
                        28479927, 29127849
                    },
                },
                new CompanyDTO {
                    id = 19754501,
                        name = "ООО \"Спорт Клуб \"Фитнес Максимум\"",
                        responsible_user_id = 2079676,
                        created_by = 2076025,
                        created_at = 1523364130,
                        updated_at = 1523364130,
                        account_id = 17769199,
                        updated_by = 2076025,
                        group_id = 151543,
                        leads = new List < int > {
                            7639405
                        },
                        closest_task_at = 0,
                        tags = new List < EntityDTO > {
                            new EntityDTO {
                                id = 767, name = "нетуТега"
                            }
                        },
                        contacts = new List < int > {
                            19754499,
                            19754503
                        },
                        customers = new List < int > (),
                        custom_fields = new List < CustomFieldDTO > {
                            new CustomFieldDTO {
                                id = 72355,
                                    name = "БИК",
                                    is_system = false,
                                    values = new List < CustomFieldValueDTO > {
                                        new CustomFieldValueDTO {
                                            value = "044525503"
                                        }
                                    }
                            },
                            new CustomFieldDTO {
                                id = 72371,
                                    name = "Должность руководителя",
                                    is_system = false,
                                    values = new List < CustomFieldValueDTO > {
                                        new CustomFieldValueDTO {
                                            value = "Генеральный директор"
                                        }
                                    }
                            }
                        }
                },
                               new CompanyDTO {
                    id = 15174275,
                        name = "ИП Андриенко Артем Александрович",
                        responsible_user_id = 2079676,
                        created_by = 2076025,
                        created_at = 1519899285,
                        updated_at = 1519899285,
                        account_id = 17769199,
                        updated_by = 2076025,
                        group_id = 151543,
                        leads = new List < int > {
                            4854637,
                            6549874
                        },
                        closest_task_at = 0,
                        tags = new List < EntityDTO > {
                            new EntityDTO {
                                id = 767, name = "tgg"
                            }
                        },
                        contacts = new List < int > {
                            14859539,
                            14859745
                        },
                        customers = new List < int > (),
                        custom_fields = new List < CustomFieldDTO > {
                            new CustomFieldDTO {
                                id = 72375,
                                    name = "ФИО Руководителя",
                                    is_system = false,
                                    values = new List < CustomFieldValueDTO > {
                                        new CustomFieldValueDTO {
                                            value = "Снастина Лилия Олеговна"
                                        }
                                    }
                            },
                            new CustomFieldDTO {
                                id = 72345,
                                    name = "Наименование банка",
                                    is_system = false,
                                    values = new List < CustomFieldValueDTO > {
                                        new CustomFieldValueDTO {
                                            value = "Сбербанк России г. Брянск"
                                        }
                                    }
                            }
                        }
                },
                new CompanyDTO {
                    id = 19701,
                        name = "Таня Жопа",
                        responsible_user_id = 276,
                        created_by = 6025,
                        created_at = 3364130,
                        updated_at = 64130,
                        account_id = 69199,
                        updated_by = 76025,
                        group_id = 1543,
                        leads = new List < int > {
                            588405
                        },
                        closest_task_at = 0,
                        tags = new List < EntityDTO > {
                            new EntityDTO {
                                id = 767, name = "нетуТега"
                            },
                            new EntityDTO {
                                id = 98, name = "Lега"
                            }
                        },
                        contacts = new List < int > {
                            99954499,
                            77854503
                        },
                        customers = new List < int > (),
                        custom_fields = new List < CustomFieldDTO > {
                            new CustomFieldDTO {
                                id = 345355,
                                    name = "Поле",
                                    is_system = false,
                                    values = new List < CustomFieldValueDTO > {
                                        new CustomFieldValueDTO {
                                            value = "Значение поля"
                                        }
                                    }
                            },
                            new CustomFieldDTO {
                                id = 371,
                                    name = "Город",
                                    is_system = false,
                                    values = new List < CustomFieldValueDTO > {
                                        new CustomFieldValueDTO {
                                            value = "Хабаровск"
                                        }
                                    }
                            }
                        }
                }

            };
        }
    }
}