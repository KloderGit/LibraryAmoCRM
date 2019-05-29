using LibraryAmoCRM.Configuration;
using LibraryAmoCRM.Infarstructure.Attributes;
using System.Collections.Generic;

namespace LibraryAmoCRM.Infarstructure.QueryParams
{
    public class NoteFilter : CoreFilter
    {
        /// <summary>
        /// Получение данных по типу указанной сущности (lead/contact/company/customer)
        /// </summary>
        [QueryParamName("type")]
        public string ForEntity { get; set; }

        /// <summary>
        /// Фильтр поиска по id сущности
        /// </summary>
        [QueryParamName("element_id")]
        public int ElementId { get; set; }

        /// <summary>
        /// Фильтр поиска по типу примечанию
        /// </summary>
        [QueryParamName("e_type")]
        public NoteType NoteType { get; set; }
    }
}