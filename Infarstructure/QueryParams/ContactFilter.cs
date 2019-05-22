using System.Collections.Generic;
using System.Text.RegularExpressions;

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

        /// <summary>
        /// Фильтр на совпадение телефону для ограничения кода страны
        /// </summary>
        public string Phone
        {
            set
            {
                Regex regex = new Regex(@"[^0-9]");
                string str = regex.Replace(value.ToString(), "");

                string substring = str.Length >= 10 ? str.Substring(str.Length - 10) : str;

                result = new KeyValuePair<string, string>("query", substring);
            }
        }
    }
}