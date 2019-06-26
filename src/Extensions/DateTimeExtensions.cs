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

        public static DateTime GetDateTimeFromUnixTime(this uint ticks)
        {
            if (ticks == 0) return DateTime.MinValue;
            var startDate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            var result = startDate.AddSeconds(ticks).ToLocalTime();

            return result;
        }
    }
}
