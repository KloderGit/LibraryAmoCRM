using LibraryAmoCRM;
using System.Collections.Generic;

namespace LibraryAmoCRM.Infarstructure.QueryParams
{
    public class CatalogElementFilter : CoreFilter
    {

        /// <summary>
        /// Выбор из католога с Id
        /// </summary>
        public int CatalogId
        {
            set => result = new KeyValuePair<string, string>( "catalog_id", value.ToString() );
        }

        /// <summary>
        /// Выбор элемента по названию
        /// </summary>
        public string Title
        {
            set => result = new KeyValuePair<string, string>( "term", value );
        }

        /// <summary>
        /// Выбор элемента со страницы
        /// </summary>
        public int Page
        {
            set => result = new KeyValuePair<string, string>( "PAGEN_1", value.ToString() );
        }
    }
}