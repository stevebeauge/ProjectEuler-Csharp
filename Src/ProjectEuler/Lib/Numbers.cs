using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib
{
    public static class Numbers
    {
        public static IEnumerable<int> GetTriangleNumbersInt32()
        {
            int current = 1;
            int sum = 0;

            while (true)
            {
                yield return sum += current++;
            }
        }
        public static IEnumerable<long> GetTriangleNumbersInt64()
        {
            long current = 1;
            long sum = 0;

            while (true)
            {
                yield return sum += current++;
            }
        }
    }
}
