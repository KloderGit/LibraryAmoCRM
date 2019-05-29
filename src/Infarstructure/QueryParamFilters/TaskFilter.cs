using LibraryAmoCRM.Infarstructure.Attributes;
using System.Collections.Generic;

namespace LibraryAmoCRM.Infarstructure.QueryParams
{
    public class TaskFilter : PeriodFilter
    {
        /// <summary>
        /// Получение данных по типу указанной сущности (lead/contact/company/customer)
        /// </summary>
        [QueryParamName("type")]
        public string ForEntity { get; set; }
        /// <summary>
        /// фильтр поиска по id сущности
        /// </summary>
        [QueryParamName("element_id[]")]
        public int ElementId { get; set; }
        /// <summary>
        /// фильтр поиска по статусу задачи
        /// </summary>
        [QueryParamName("filter[status][]")]
        public bool Status { get; set; }
        /// <summary>
        /// Фильтр по создателю задачи
        /// </summary>
        [QueryParamName("filter[created_by][]")]
        public int CreatedBy { get; set; }
        /// <summary>
        /// Фильтр по типу задачи
        /// </summary>
        [QueryParamName("filter[task_type][]")]
        public int TaskType { get; set; }
    }
}