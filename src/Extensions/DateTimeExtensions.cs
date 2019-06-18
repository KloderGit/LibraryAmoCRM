using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Extensions
{
    internal static class DateTimeExtensions
    {
        public static uint GetUnixTimeSeconds(this DateTime source)
        {
            var date = source.ToUniversalTime();
            var unixTime = ((DateTimeOffset)date).ToUnixTimeSeconds();

            if (source == DateTime.MinValue) unixTime = 0;

            return Convert.ToUInt32(unixTime);
        }
    }
}
