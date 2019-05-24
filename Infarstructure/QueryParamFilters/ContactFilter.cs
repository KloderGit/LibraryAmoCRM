using LibraryAmoCRM.Infarstructure.Attributes;
using LibraryAmoCRM.Infarstructure.QueryParamFilters;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LibraryAmoCRM.Infarstructure.QueryParams
{
    public class ContactFilter : PeriodFilter
    {
        public int pole;
        /// <summary>
        /// Фильтр на совпадение в основных полях контактов и по связанным Id
        /// </summary>
        [QueryParamName("query")]
        public string Query { get; set; }

        /// <summary>
        /// Фильтр на совпадение по телефону
        /// </summary>
        [QueryParamName("query")]
        public string Phone { get; set; }
    }
}