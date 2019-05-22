using System.Collections.Generic;

namespace LibraryAmoCRM.Infarstructure.QueryParams
{
    public class TaskFilter : PeriodFilter
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
    }
}