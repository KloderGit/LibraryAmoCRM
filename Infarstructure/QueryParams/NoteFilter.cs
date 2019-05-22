using LibraryAmoCRM.Configuration;
using System.Collections.Generic;

namespace LibraryAmoCRM.Infarstructure.QueryParams
{
    public class NoteFilter : CoreFilter
    {
        /// <summary>
        /// Получение данных по типу указанной сущности (lead/contact/company/customer)
        /// </summary>
        public string ForEntity
        {
            set => result = new KeyValuePair<string, string>( "type", value );
        }

        /// <summary>
        /// фильтр поиска по id сущности
        /// </summary>
        public int ElementId
        {
            set => result = new KeyValuePair<string, string>( "element_id", value.ToString() );
        }

        /// <summary>
        /// фильтр поиска по типу примечанию
        /// </summary>
        public NoteType NoteType
        {
            set => result = new KeyValuePair<string, string>( "e_type", ((int)value).ToString() );
        }
    }
}