using System.Collections.Generic;

namespace LibraryAmoCRM.Infarstructure.QueryParams
{
    public class CustomerFilter : PeriodFilter
    {
        /// <summary>
        /// Фильтр на совпадение в основных полях контактов и по связанным Id
        /// </summary>
        public string Query
        {
            set => result = new KeyValuePair<string, string>( "query", value.ToString() );
        }
    }
}