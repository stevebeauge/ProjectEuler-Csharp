using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Concurrent;
using System.Threading;

namespace Lib.Extentions
{
    public static class FuncExtentions
    {
        public static Func<A, R> Memoize<A, R>(this Func<A, R> f)
        {
            var map = new ConcurrentDictionary<A, Lazy<R>>();
            return a =>
            {
                Lazy<R> lazy = new Lazy<R>(() => f(a), LazyThreadSafetyMode.ExecutionAndPublication);
                if (!map.TryAdd(a, lazy))
                {
                    return map[a].Value;
                }
                return lazy.Value;
            };
        }
    }
}
