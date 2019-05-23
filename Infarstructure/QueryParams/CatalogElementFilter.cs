using LibraryAmoCRM;
using LibraryAmoCRM.Infarstructure.Attributes;
using System.Collections.Generic;

namespace LibraryAmoCRM.Infarstructure.QueryParams
{
    public class CatalogElementFilter : CoreFilter
    {

        /// <summary>
        /// Выбор из католога с Id
        /// </summary>
        [QueryParamName("catalog_id")]
        public int CatalogId { get; set; }

        /// <summary>
        /// Выбор элемента по названию
        /// </summary>
        [QueryParamName("term")]
        public string Title { get; set; }

        /// <summary>
        /// Выбор элемента со страницы
        /// </summary>
        [QueryParamName("PAGEN_1")]
        public int Page { get; set; }
    }
}