using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LibraryAmoCRM.Infarstructure.QueryParams
{
    public class Param
    {
        public KeyValuePair<string, string> result;

        public int Id
        {
            set => result = new KeyValuePair<string, string>("id", value.ToString());
        }

        public int Limit
        {
            set => result = new KeyValuePair<string, string>("limit_rows", value.ToString());
        }

        public int Offset
        {
            set => result = new KeyValuePair<string, string>("limit_offset", value.ToString());
        }

        public int ResponsibleUser
        {
            set => result = new KeyValuePair<string, string>("responsible_user_id", value.ToString());
        }

        public int Status
        {
            set => result = new KeyValuePair<string, string>("status", value.ToString());
        }

        public string Query
        {
            set => result = new KeyValuePair<string, string>("query", value.ToString());
        }

        public string ModifyFrom
        {
            set => result = new KeyValuePair<string, string>("modyfy", value.ToString());
        }

        public string Phone
        {
            set {
                Regex regex = new Regex(@"[^0-9]");
                string str = regex.Replace(value.ToString(), "");

                string substring = str.Length >= 10 ? str.Substring(str.Length - 10) : str;

                result = new KeyValuePair<string, string>("query", substring);
            }
        }
    }



}
