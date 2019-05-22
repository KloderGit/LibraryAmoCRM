using System.Collections.Generic;

namespace LibraryAmoCRM.Infarstructure.QueryParams
{
    public class LeadFilter : PeriodFilter
    {
        /// <summary>
        /// Фильтр на совпадение в основных полях сделки или контактов (телефон, почта, название, фио и пр.)
        /// </summary>
        public string Query
        {
            set => result = new KeyValuePair<string, string>( "query", value.ToString() );
        }

        /// <summary>
        /// Фильтр сделок на определенных статусах
        /// </summary>
        public int Status
        {
            set => result = new KeyValuePair<string, string>( "status[]", value.ToString() );
        }

        /// <summary>
        /// Фильтр активныч сделок
        /// </summary>
        public bool Active
        {
            set => result = new KeyValuePair<string, string>( "filter[active]", value ? "1" : "0" );
        }

        /// <summary>
        /// Фильтр сделок: без задач - 0 \ с просроченными задачами - 1
        /// </summary>
        public bool WithTaskTypes
        {
            set => result = new KeyValuePair<string, string>( "filter[tasks]", value ? "1" : "0" );
        }
    }
}