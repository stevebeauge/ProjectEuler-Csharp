using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib
{
    public static class CoinChangeAlgorithm
    {
        public static long CountSolution(long target, IEnumerable<long> coinsValue)
        {
            var ways = new long[target+1];
            ways[0] = 1;

            foreach (var coin in coinsValue)
            {
                for (var i = coin; i <= target; i++)
                {
                    ways[i] += ways[i - coin];
                }
            }

            return ways.Last();
        }

        public static long CountSolution(long target, params long[] coinsValue)
        {
            return CountSolution(target, (IEnumerable<long>)coinsValue);
        }
    }
}
