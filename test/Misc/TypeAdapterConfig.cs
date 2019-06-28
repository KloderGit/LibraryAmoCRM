using LibraryAmoCRM.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRMTests.Misc
{
    public static class TypeAdapterConfig
    {
        static TypeAdapterConfig()
        {
            new CommonMapping();
            new ContactMapping();
            new CompanyMapping();
        }
    }
}
