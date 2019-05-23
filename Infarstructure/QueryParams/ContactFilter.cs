using LibraryAmoCRM.Infarstructure.Attributes;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LibraryAmoCRM.Infarstructure.QueryParams
{
    public class ContactFilter : PeriodFilter
    {
        /// <summary>
        /// Фильтр на совпадение в основных полях контактов и по связанным Id
        /// </summary>
        [QueryParamName("query")]
        public string Query { get; set; }

        /// <summary>
        /// Фильтр на совпадение телефону для ограничения кода страны
        /// </summary>
        [QueryParamName("query")]
        public string Phone { get; set; }
    }
}