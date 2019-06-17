using LibraryAmoCRM.DTO;
using LibraryAmoCRM.Interfaces;
using LibraryAmoCRM.Models;
using Mapster;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Mappings
{
    internal abstract class ToDtoFunction
    {
        protected uint GetUnixTimeSeconds(DateTime value)
        {
            var date = value.ToUniversalTime();
            var unixTime = ((DateTimeOffset)date).ToUnixTimeSeconds();

            if (value == DateTime.MinValue)
            {
                unixTime = 0;
            }

            return Convert.ToUInt32(unixTime);
        }
    }
}
