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