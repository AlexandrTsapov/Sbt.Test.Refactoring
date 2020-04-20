using System;
using System.Collections;
using System.Linq;

namespace Sbt.Test.Refactoring.Collections
{
    public static class LinqHelper
    {
        public static void ExequteOfType<T>(this IEnumerable enumerable, Action<T> action)
        {
            foreach (var item in enumerable.OfType<T>())
            {
                action(item);
            }
        }
    }
}
