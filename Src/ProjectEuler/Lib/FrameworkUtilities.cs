using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace Lib
{
    public static class FrameworkUtilities
    {
        public static TimeSpan Measure(Action a)
        {
            Contract.Requires<ArgumentNullException>(a != null);
            var stopWatch = Stopwatch.StartNew();
            a();
            stopWatch.Stop();
            return stopWatch.Elapsed;
        }
        public static TimeSpan Measure<TResult>(Func<TResult> f, out TResult result)
        {
            Contract.Requires<ArgumentNullException>(f != null);
            var stopWatch = Stopwatch.StartNew();
            result = f();
            stopWatch.Stop();
            return stopWatch.Elapsed;
        }
    }
}
