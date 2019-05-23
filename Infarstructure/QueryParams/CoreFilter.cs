using LibraryAmoCRM.Infarstructure.Attributes;
using System.Collections.Generic;

namespace LibraryAmoCRM.Infarstructure.QueryParams
{
    public abstract class CoreFilter
    {
        public KeyValuePair<string, string> result;

        /// <summary>
        /// Фильтр по Id сущности
        /// </summary>
        [QueryParamName("id[]")]
        public int Id { get; set; }

        /// <summary>
        /// Лимит выборки (ограничение по умолчанию - 500)
        /// </summary>
        [QueryParamName("limit_rows")]
        public int LimitRows { get; set; }

        /// <summary>
        /// Смещение выборки. Устанавливается только с LimitRows
        /// </summary>
        [QueryParamName("limit_offset")]
        public int LimitOffset { get; set; }
    }
}