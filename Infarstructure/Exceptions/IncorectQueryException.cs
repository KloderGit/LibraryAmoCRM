using System;

namespace LibraryAmoCRM.Infarstructure.Exceptions
{
    public class IncorectQueryException : Exception
    {
        public IncorectQueryException(string message) : base(message)
        {
        }
    }
}
