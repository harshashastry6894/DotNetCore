using System;
using System.Globalization;

namespace MyApp.Exceptions
{
    // custom exception class for throwing application specific exceptions 
    // that can be caught and handled within the application
    public class GlobalException : Exception
    {
        public GlobalException() : base() {}

        public GlobalException(string message) : base(message) { }

        public GlobalException(string message, params object[] args) 
            : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}