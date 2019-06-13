using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace LibraryAmoCRM.Interfaces
{
    public interface IConnection
    {
        HttpClient Client { get; set; }
        void Auth(object obj);
        string GetEndPoint<T>();
    }
}
