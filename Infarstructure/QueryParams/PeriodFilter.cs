using LibraryAmoCRM.Infarstructure.Attributes;
using System;
using System.Collections.Generic;

namespace LibraryAmoCRM.Infarstructure.QueryParams
{
    public abstract class PeriodFilter : CoreFilter
    {
        /// <summary>
        /// Фильтр по ответственным менеджерам
        /// </summary>
        [QueryParamName("responsible_user_id[]")]
        public int ResponsibleUser { get; set; }

        /// <summary>
        /// Фильтр - даты создания старше чем дата
        /// </summary>
        [QueryParamName("filter[date_create][from]")]
        public DateTime CreateFrom { get; set; }

        /// <summary>
        /// Фильтр - даты создания до даты
        /// </summary>
        [QueryParamName("filter[date_create][to]")]
        public DateTime CreateTo { get; set; }

        /// <summary>
        /// Фильтр - даты изменения старше чем дата
        /// </summary>
        [QueryParamName("filter[date_modify][from]")]
        public DateTime ModifyFrom { get; set; }

        /// <summary>
        /// Фильтр - даты изменения до даты
        /// </summary>
        [QueryParamName("filter[date_modify][to]")]
        public DateTime ModifyTo { get; set; }
    }
}