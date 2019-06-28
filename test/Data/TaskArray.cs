using LibraryAmoCRM.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRMTests.Data
{
    public static class TaskArray
    {
        internal static IEnumerable<TaskDTO> GetTaskDTOs()
        {
            return new List<TaskDTO>
            {
                new TaskDTO{
                    id = 2061247,
                    responsible_user_id = 2079682,
                    created_by = 2076025,
                    created_at = 1519813764,
                    updated_at = 1519813844,
                    account_id = 17769199,
                    group_id = 151543,
                    duration = 0,
                    element_type = 2,
                    element_id = 4774969,
                    is_completed = true,
                    task_type = 786424,
                    complete_till_at = 1528145940,
                    text = "Уточнить",
                    result = new IntentDTO{
                        id = 37799293,
                        text = "На Персон тр"
                    }
                },
                new TaskDTO{
                    id = 1957057,
                    responsible_user_id = 2079679,
                    created_by = 2076025,
                    created_at = 1519730633,
                    updated_at = 1519823086,
                    account_id = 17769199,
                    group_id = 151543,
                    duration = 0,
                    element_type = 1,
                    element_id = 14390293,
                    is_completed = true,
                    task_type = 1,
                    complete_till_at = 1519730633,
                    text = "Клиент заказал обратный звонок! Узнать что хотел!"
                }
            };
        }
    }
}
