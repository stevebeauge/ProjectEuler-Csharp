using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics.Contracts;

namespace Lib
{
    public static class CoinChangeAlgorithm
    {
        public static ulong CountSolution(ulong target, IEnumerable<ulong> coinsValue)
        {
            Contract.Requires<ArgumentOutOfRangeException>(target > 0, "The target must be a positive integer");
            Contract.Requires<ArgumentOutOfRangeException>(target<ulong.MaxValue -2);
            Contract.Requires<ArgumentNullException>(coinsValue != null);
            Contract.Requires<ArgumentException>(coinsValue.Count() > 0);
            Contract.Requires<ArgumentException>(coinsValue.All(c => c > 0), "All coins must be > 0");
   
            var ways = new ulong[target+1];
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

        public static ulong CountSolution(ulong target, params ulong[] coinsValue)
        {
            Contract.Requires<ArgumentOutOfRangeException>(target > 0, "The target must be a positive integer");
            Contract.Requires<ArgumentOutOfRangeException>(target < ulong.MaxValue - 1);
            Contract.Requires<ArgumentNullException>(coinsValue != null);
            Contract.Requires<ArgumentException>(coinsValue.Count() > 0);
            Contract.Requires<ArgumentException>(coinsValue.All(c => c > 0), "All coins must be > 0");
            return CountSolution(target, (IEnumerable<ulong>)coinsValue);
        }
        public static uint CountSolution(uint target, IEnumerable<uint> coinsValue)
        {
            Contract.Requires<ArgumentOutOfRangeException>(target > 0, "The target must be a positive integer");
            Contract.Requires<ArgumentOutOfRangeException>(target < uint.MaxValue - 1);
            Contract.Requires<ArgumentNullException>(coinsValue != null);
            Contract.Requires<ArgumentException>(coinsValue.Count() > 0);
            Contract.Requires<ArgumentException>(coinsValue.All(c => c > 0), "All coins must be > 0");
            
            var ways = new uint[target + 1];
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

        public static uint CountSolution(uint target, params uint[] coinsValue)
        {
            Contract.Requires<ArgumentOutOfRangeException>(target > 0, "The target must be a positive integer");
            Contract.Requires<ArgumentOutOfRangeException>(target < uint.MaxValue - 1);
            Contract.Requires<ArgumentNullException>(coinsValue != null);
            Contract.Requires<ArgumentException>(coinsValue.Count() > 0);
            Contract.Requires<ArgumentException>(coinsValue.All(c => c > 0), "All coins must be > 0");
            
            return CountSolution(target, (IEnumerable<uint>)coinsValue);
        }
    }
}
