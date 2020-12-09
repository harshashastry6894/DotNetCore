using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace MyApp.Exceptions
{
    public static class FailureExceptions
    {
        public static T FirstOrFail<T>([NotNull] this IEnumerable<T> query, string message)
        {
            try
            {
                return query.First();
            }
            catch (InvalidOperationException)
            {
                throw new KeyNotFoundException(message);
            }
        }
    }
}