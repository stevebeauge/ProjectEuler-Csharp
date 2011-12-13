using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib
{
    public static class IntegerExtensions
    {
        public static bool IsEven(this int i)
        {
            return i%2==0;
        }
        public static bool IsOdd(this int i)
        {
            return !i.IsEven();
        }
        public static bool IsEven(this long i)
        {
            return i%2==0;
        }

        public static bool IsOdd(this long i)
        {
            return !i.IsEven();
        }

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

        public static IEnumerable<long> GetDivisors(this long number)
        {
            yield return 1;
            for (long i = 0; i < Math.Sqrt(number); i++)
            {
                if (number % i == 0) yield return i;
            }
        }
        public static IEnumerable<short> GetDivisors(this short number)
        {
            yield return 1;
            for (short i = 0; i < Math.Sqrt(number); i++)
            {
                if (number % i == 0) yield return i;
            }
        }
        public static IEnumerable<int> GetDivisors(this int number)
        {
            yield return 1;
            for (int i = 2; i <= number /2; i++)
            {
                if (number % i == 0) yield return i;
            }
        }
    }
}
