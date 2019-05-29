using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryAmoCRM.Configuration
{
    public class QueryPerSecond
    {
        public DateTime LastQueryTime { get; set; } = DateTime.Now;

        public void NeedWait()
        {
            var difftime = DateTime.Now.Subtract(LastQueryTime);

            if (difftime.Milliseconds < 1000)
                Thread.Sleep(1000 - difftime.Milliseconds);
            LastQueryTime = DateTime.Now;
        }
    }
}
