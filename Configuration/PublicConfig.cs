using LibraryAmoCRM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Configuration
{
    public class PublicConfig
    {
        public static Dictionary<string, Type> TypeForEvent { get; set; } = new Dictionary<string, Type> {
            { "lead", typeof(LeadDTO) },
            { "contact", typeof(ContactDTO) },
            { "company", typeof(CompanyDTO) },
            { "tasks", typeof(TaskDTO) }
        };


    }

    public enum Users
    {
        Robot = 2076025,
        Лина_Серрие = 2079676,
        Анастасия_Столовая = 2079679,
        Ирина_Моисеева = 2079682,
        Евгения_Ковалева = 2079688,
        Наталья_Бердникова = 2079706,
        Мила_Коммендантова = 2079712,
        Илья_Иджян = 2079718,
        Ксения_Харымова = 2267437
    }

    public enum TaskType
    {
        Звонок = 1,
        Встреча = 2,
        Написать_письмо = 3
    }

    public enum ElementType
    {
        Контакт = 1,
        Сделка = 2,
        Компания = 3,
        Задача = 4,
    }

    public enum NoteType
    {
        DEAL_CREATED = 1,
        CONTACT_CREATED = 2,
        DEAL_STATUS_CHANGED = 3,
        COMMON = 4,
        CALL_IN = 10,
        CALL_OUT = 11,
        COMPANY_CREATED = 12,
        TASK_RESULT = 13,
        SYSTEM = 25,
        SMS_IN = 102,
        SMS_OUT = 103
    }
}
