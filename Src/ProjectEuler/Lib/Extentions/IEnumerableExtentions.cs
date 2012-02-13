using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics.Contracts;

namespace Lib.Extentions
{
    public static class IEnumerableExtentions
    {
        public static IEnumerable<TResult> SelectWithPosition<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
        {
            Contract.Requires<ArgumentNullException>(source != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            int i = 0;

            foreach (var item in source)
            {
                yield return selector( item,++i);
            }
        }
        public static IEnumerable<TResult> SelectWithOffset<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
        {
            Contract.Requires<ArgumentNullException>(source != null);
            Contract.Requires<ArgumentNullException>(selector != null);
            int i = 0;

            foreach (var item in source)
            {
                yield return selector( item,i++);
            }
        }



        public static IEnumerable<IEnumerable<T>> GetPermutations<T>(this IEnumerable<T> source)
        {
            //Contract.Requires<ArgumentNullException>(source != null);
            //var c = source.Count();
            //if (c == 1)
            //{
            //    yield return source;
            //}
            //else
            //{
            //    for (int i = 0; i < c; i++)
            //        foreach (var p in GetPermutations(source.Take(i).Concat(source.Skip(i + 1))))
            //            yield return source.Skip(i).Take(1).Concat(p);
            //}
            return Permutation.Enumerate(source.ToArray());
        }

        public static IEnumerable<IEnumerable<T>> GetRotations<T>(this IEnumerable<T> source)
        {
            Contract.Requires<ArgumentNullException>(source != null);

            var count = source.Count();
            for (int i = 0; i < count; i++)
            {
                yield return Enumerable.Concat(
                    source.Skip(i),
                    source.Take(i)
                    );
            }
        }

        public static ulong Sum(this IEnumerable<ulong> source)
        {
            Contract.Requires<ArgumentNullException>(source != null);

            ulong result = 0;
            foreach (var n in source)
            {
                result += n;
            }
            return result;
        }


    }
}
