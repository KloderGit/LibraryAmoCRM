using LibraryAmoCRM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Infarstructure.Event
{
    internal class RelativeEventArgs : EventArgs
    {
        public dynamic SourceType { get; set; }
        public object Child { get; set; }
    }
}
