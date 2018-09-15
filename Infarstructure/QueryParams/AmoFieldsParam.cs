using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Infarstructure.QueryParams
{
    public class AmoFieldsParam
    {
        public KeyValuePair<string, string> result;

        public int Id
        {
            set => result = new KeyValuePair<string, string>("id", value.ToString());
        }
    }
}
