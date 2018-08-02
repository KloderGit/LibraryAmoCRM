using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLibraryAmoCRM.Infarstructure.Exceptions
{
    public class IncorectQueryException : Exception
    {
        public IncorectQueryException(string message) : base(message)
        {
        }
    }
}
