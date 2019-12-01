using System;
using System.Collections.Generic;

namespace KawataSwitcher.Extensions
{
    static class EnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> items, Action<T> action)
        {
            foreach (var i in items)
            {
                action(i);
            }
        }
    }
}
