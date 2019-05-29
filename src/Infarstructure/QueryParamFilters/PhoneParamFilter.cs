using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LibraryAmoCRM.Infarstructure.QueryParamFilters
{
    public class PhoneParamFilter
    {
        private string phone; 

        public PhoneParamFilter(string phone)
        {
            this.phone = PreparePhone(phone);
        }

        private string PreparePhone(string phone)
        {
            Regex regex = new Regex(@"[^0-9]");
            string str = regex.Replace(phone, "");

            return str.Length >= 10 ? str.Substring(str.Length - 10) : str;
        }

        public override string ToString()
        {
            return phone;
        }
    }
}
