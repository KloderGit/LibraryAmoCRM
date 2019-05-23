using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Infarstructure.Attributes
{
    public class QueryParamNameAttribute : Attribute
    {
        public string Name { get; set; }

        public QueryParamNameAttribute (string name) => Name = name;
    }
}
