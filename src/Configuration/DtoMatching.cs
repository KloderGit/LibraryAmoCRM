using LibraryAmoCRM.DTO;
using LibraryAmoCRM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Configuration
{
    internal static class MatchingDTO
    {
        private static readonly Dictionary<Type, Type> dto = new Dictionary<Type, Type>()
        {
            { typeof(Contact), typeof(HAL<ContactDTO>) },
            { typeof(Company), typeof(HAL<CompanyDTO>) },
            { typeof(Note), typeof(HAL<NoteDTO>) },
            { typeof(Task), typeof(HAL<TaskDTO>) },
            { typeof(Lead), typeof(HAL<LeadDTO>) }
        };


        public static Type GetDTOType<T>()
        {
            return dto[typeof(T)];
        }
    }
}
