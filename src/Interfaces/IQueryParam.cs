using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Interfaces
{
    public interface IQueryParam
    {
        List<KeyValuePair<string, string>> QueryParameters { get; set; }
    }
}
