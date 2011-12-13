using System.Collections.Generic;
using System;
using System.Linq;
using System.Diagnostics.Contracts;
using System.Numerics;

namespace Lib
{
    public static class Prime
    {
        private static List<ulong> g_knownPrimes = new List<ulong>() { 2, 3 }; // Cache for know primes
        private static ulong[] g_SmallFactorials = new ulong[]  {
            1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880, 3628800, 39916800, 
            479001600, 6227020800, 87178291200, 1307674368000, 20922789888000, 
            355687428096000, 6402373705728000, 121645100408832000, 2432902008176640000 };

        public static IEnumerable<long> GetPrimesFactor(this long number)
        {
            for (long i = 2; i <= number / 2; i++)
            {
                while (number % i == 0)
                {
                    yield return i;
                    number /= i;
                }
            }
            yield return number;
        }

        public static IEnumerable<ulong> GetPrimes(ulong uBound = ulong.MaxValue)
        {
            yield return 2;
            for (ulong i = 3; i < uBound; i += 2)
            {
                if (IsPrime(i))
                {
                    yield return i;
                    g_knownPrimes.Add(i);
                }
            }
        }

        private static bool IsPrime(ulong value)
        {
            var sqrt = (ulong)Math.Sqrt(value);
            return !g_knownPrimes
                .TakeWhile(x => x <= sqrt)
                .Any(x => value % x == 0);
        }

        public static ulong FactorialSmall(this ulong n)
        {
            Contract.Requires<ArgumentOutOfRangeException>(n <= 20, "n must be less than or equals to 20 for this method to works.");
            Contract.Requires<ArgumentOutOfRangeException>(n > 0);

            return g_SmallFactorials[n];
        }

        // Taken from https://github.com/PeterLuschny/Fast-Factorial-Functions/blob/master/SilverFactorial64/Sharith/Factorial/FactorialSplit.cs
        public static BigInteger Factorial(this int n)
        {

            if (n < 2) return BigInteger.One;

            BigInteger p = BigInteger.One;
            BigInteger r = BigInteger.One;
            BigInteger currentN = BigInteger.One;

            int h = 0, shift = 0, high = 1;
            int log2n = FloorLog2(n);

            while (h != n)
            {
                shift += h;
                h = n >> log2n--;
                int len = high;
                high = (h - 1) | 1;
                len = (high - len) / 2;

                if (len > 0)
                {
                    p *= Product(len, ref currentN);
                    r *= p;
                }
            }

            return r << shift;
        }

        #region Internals
        // Taken from https://github.com/PeterLuschny/Fast-Factorial-Functions/blob/master/SilverFactorial64/Sharith/MathUtils/XMath.cs
        public static int BitLength(int w)
        {
            return (w < 1 << 15
            ? (w < 1 << 7 ? (w < 1 << 3 ? (w < 1 << 1 ? (w < 1 << 0 ? (w < 0 ? 32 : 0) : 1)
            : (w < 1 << 2 ? 2 : 3)) : (w < 1 << 5 ? (w < 1 << 4 ? 4 : 5) : (w < 1 << 6 ? 6 : 7)))
            : (w < 1 << 11 ? (w < 1 << 9 ? (w < 1 << 8 ? 8 : 9) : (w < 1 << 10 ? 10 : 11))
            : (w < 1 << 13 ? (w < 1 << 12 ? 12 : 13) : (w < 1 << 14 ? 14 : 15))))
            : (w < 1 << 23
            ? (w < 1 << 19 ? (w < 1 << 17 ? (w < 1 << 16 ? 16 : 17) : (w < 1 << 18 ? 18 : 19))
            : (w < 1 << 21 ? (w < 1 << 20 ? 20 : 21) : (w < 1 << 22 ? 22 : 23)))
            : (w < 1 << 27
            ? (w < 1 << 25 ? (w < 1 << 24 ? 24 : 25) : (w < 1 << 26 ? 26 : 27))
            : (w < 1 << 29 ? (w < 1 << 28 ? 28 : 29)
            : (w < 1 << 30 ? 30 : 31)))));
        }
        private static int FloorLog2(int n)
        {
            if (n <= 0)
            {
                throw new System.ArgumentOutOfRangeException("n >= 0 required");
            }
            return BitLength(n) - 1;
        }
        private static BigInteger Product(int n, ref BigInteger currentN)
        {
            int m = n / 2;
            if (m == 0) return currentN += 2;
            if (n == 2) return (currentN += 2) * (currentN += 2);
            return Product(n - m, ref currentN) * Product(m, ref currentN);
        }
        #endregion
    }
}
