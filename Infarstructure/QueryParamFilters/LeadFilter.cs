using LibraryAmoCRM.Infarstructure.Attributes;
using System.Collections.Generic;

namespace LibraryAmoCRM.Infarstructure.QueryParams
{
    public class LeadFilter : PeriodFilter
    {
        /// <summary>
        /// Фильтр на совпадение в основных полях сделки или контактов (телефон, почта, название, фио и пр.)
        /// </summary>
        [QueryParamName("query")]
        public string Query { get; set; }

        /// <summary>
        /// Фильтр сделок на определенных статусах
        /// </summary>
        [QueryParamName("status[]")]
        public int Status { get; set; }

        /// <summary>
        /// Фильтр активныч сделок
        /// </summary>
        [QueryParamName("filter[active]")]
        public bool Active { get; set; }

        /// <summary>
        /// Фильтр сделок: без задач - 0 \ с просроченными задачами - 1
        /// </summary>
        [QueryParamName("filter[tasks]")]
        public bool WithTaskTypes { get; set; }
    }
}