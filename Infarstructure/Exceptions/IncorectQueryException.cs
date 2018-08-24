using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Infarstructure.Exceptions
{
    public class IncorectQueryException : Exception
    {
        public IncorectQueryException(string message) : base(message)
        {
        }
    }
}
