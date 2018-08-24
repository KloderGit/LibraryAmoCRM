using LibraryAmoCRM.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Infarstructure.QueryParams
{
    public class CatalogParam
    {
        public KeyValuePair<string, string> result;

        public Catalogs Catalog
        {
            set
            {
                var catalogValue = (int)value;
                result = new KeyValuePair<string, string>("catalog_id", catalogValue.ToString());
            }
        }
    }
}
