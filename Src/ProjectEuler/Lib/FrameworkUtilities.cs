using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Lib
{
    public static class FrameworkUtilities
    {
        public static TimeSpan Measure(Action a)
        {
            var stopWatch = Stopwatch.StartNew();
            a();
            stopWatch.Stop();
            return stopWatch.Elapsed;
        }
        public static TimeSpan Measure<TResult>(Func<TResult> f, out TResult result)
        {
            var stopWatch = Stopwatch.StartNew();
            result = f();
            stopWatch.Stop();
            return stopWatch.Elapsed;
        }
    }
}
