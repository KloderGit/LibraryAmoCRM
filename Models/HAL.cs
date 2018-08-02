using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLibraryAmoCRM.Models
{
    public class HAL<T>
    {
        public links _links { get; set; }
        public embedded<T> _embedded { get; set; }
    }

    public class links {
        public self self { get; set; }
    }

    public class self {
        public string href { get; set; }
        public string method { get; set; }
    }

    public class embedded<T>
    {
        public IEnumerable<T> items { get; set; }
    }
}