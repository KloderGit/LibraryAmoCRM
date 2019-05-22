using System.Collections.Generic;

namespace LibraryAmoCRM.Infarstructure.QueryParams
{
    public abstract class CoreFilter
    {
        public KeyValuePair<string, string> result;

        /// <summary>
        /// Фильтр по Id сущности
        /// </summary>
        public int Id
        {
            set => result = new KeyValuePair<string, string>( "id[]", value.ToString() );
        }

        /// <summary>
        /// Лимит выборки (ограничение по умолчанию - 500)
        /// </summary>
        public int LimitRows
        {
            set => result = new KeyValuePair<string, string>( "limit_rows", value.ToString() );
        }

        /// <summary>
        /// Смещение выборки. Устанавливается только с LimitRows
        /// </summary>
        public int LimitOffset
        {
            set => result = new KeyValuePair<string, string>( "limit_offset", value.ToString() );
        }
    }
}