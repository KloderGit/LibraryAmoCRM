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
            { typeof(Contact), typeof(HAL<ContactDTO>) }
        };


        public static Type GetDTOType<T>()
        {
            return dto[typeof(T)];
        }
    }
}
