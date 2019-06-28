using LibraryAmoCRM.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRMTests.Data
{
    public static class LeadArray
    {
        internal static IEnumerable<LeadDTO> GetLeadDTO()
        {
            var array = new List<LeadDTO>();

            var lead1 = new LeadDTO {
                id = 4741071,
                name = "Семинар: Основы разработки индивидуальных тренировочных программ для формирования красивого сложения у женщин",
                responsible_user_id = 2079676,
                created_by = 2076025,
                created_at = 1519739511,
                updated_at = 1520261195,
                account_id = 17769199,
                pipeline_id = 917056,
                status_id = 143,
                is_deleted = false,
                main_contact = new Element { id = 14508427 },
                group_id = 151543,
                company = null,
                closed_at = 1520261193,
                closest_task_at = 0,
                tags = new List<EntityDTO> { new EntityDTO { id = 80147, name = "повторное обращение" } },
                custom_fields = new List<CustomFieldDTO> {
                    new CustomFieldDTO{
                        id = 66339,
                        name = "Источник",
                        is_system = false,
                        values = new List<CustomFieldValueDTO>{
                           new CustomFieldValueDTO{
                                @enum = 139517,
                                value = "Сайт"
                           }
                        }
                    },
                    new CustomFieldDTO{
                        id = 72333,
                        name = "Дата проведения",
                        is_system = false,
                        values = new List<CustomFieldValueDTO>{
                           new CustomFieldValueDTO{
                                value = "2018-03-18 00:00:00"
                           }
                        }
                    }
                },
                contacts = new List<int> { 14508427 },
                sale = 4500,
                loss_reason_id = 0,
                pipeline = new Element { id = 917056 }
            };

            array.Add(lead1);

            return array;
        }
    }
}
