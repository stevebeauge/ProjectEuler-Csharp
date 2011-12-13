using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib
{
    public static class IEnumerableExtentions
    {
        public static IEnumerable<TResult> SelectWithIndex<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
        {
            int i = 0;

            foreach (var item in source)
            {
                yield return selector( item,++i);
            }
        }
    }
}
