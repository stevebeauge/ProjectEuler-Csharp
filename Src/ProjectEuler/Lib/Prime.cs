using System.Collections.Generic;
using System;

namespace Lib
{
    public static class Prime
    {
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
        public static IEnumerable<int> GetPrimesFactor(this int number)
        {
            for (int i = 2; i <= number / 2; i++)
            {
                while (number % i == 0)
                {
                    yield return i;
                    number /= i;
                }
            }
            yield return number;
        }
        public static IEnumerable<int> GetPrimes(int uBound = int.MaxValue)
        {
            yield return 2;
            for (int i = 3; i < uBound; i += 2)
            {
                var skip = false;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        skip = true;
                        break;
                    }
                }
                if (skip) continue;

                yield return i;
            }
        }

    }
}
