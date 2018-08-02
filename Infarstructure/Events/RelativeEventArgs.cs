using ServiceLibraryAmoCRM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLibraryAmoCRM.Infarstructure.Event
{
    internal class RelativeEventArgs : EventArgs
    {
        public dynamic SourceType { get; set; }
        public object Child { get; set; }
    }
}
