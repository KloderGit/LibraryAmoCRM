using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAmoCRM.Interfaces
{
    public interface IAcceptParams
    {
        List<KeyValuePair<string, string>> QueryParameters { get; set; }
    }
}
