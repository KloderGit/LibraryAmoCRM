using System;
using System.Collections.Generic;

namespace LibraryAmoCRM.Infarstructure.QueryParams
{
    public abstract class PeriodFilter : CoreFilter
    {
        /// <summary>
        /// Фильтр по ответственным менеджерам
        /// </summary>
        public int ResponsibleUser
        {
            set => result = new KeyValuePair<string, string>( "responsible_user_id[]", value.ToString() );
        }

        /// <summary>
        /// Фильтр - даты создания старше чем дата
        /// </summary>
        public DateTime CreateFrom
        {
            set => result = new KeyValuePair<string, string>( "filter[date_create][from]", value.Millisecond.ToString() );
        }

        /// <summary>
        /// Фильтр - даты создания до даты
        /// </summary>
        public DateTime CreateTo
        {
            set => result = new KeyValuePair<string, string>( "filter[date_create][to]", value.Millisecond.ToString() );
        }

        /// <summary>
        /// Фильтр - даты изменения старше чем дата
        /// </summary>
        public DateTime ModifyFrom
        {
            set => result = new KeyValuePair<string, string>( "filter[date_modify][from]", value.Millisecond.ToString() );
        }

        /// <summary>
        /// Фильтр - даты изменения до даты
        /// </summary>
        public DateTime ModifyTo
        {
            set => result = new KeyValuePair<string, string>( "filter[date_modify][to]", value.Millisecond.ToString() );
        }
    }
}