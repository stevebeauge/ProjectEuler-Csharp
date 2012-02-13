using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics.Contracts;

namespace Lib.Extentions
{
    public static class IntegerExtensions
    {
        public static bool IsEven(this int i)
        {
            return i % 2 == 0;
        }
        public static bool IsOdd(this int i)
        {
            return !i.IsEven();
        }
        public static bool IsEven(this long i)
        {
            return i % 2 == 0;
        }

        public static bool IsOdd(this long i)
        {
            return !i.IsEven();
        }

        public static IEnumerable<long> GetPrimesFactor(this long number)
        {
            Contract.Requires<ArgumentOutOfRangeException>(number > 1);
            for (long i = 2; i <= number / 2; i++)
            {
                while (number % i == 0)
                {
                    yield return i;
                    number /= i;
                }
            }
            if(number>1) yield return number;
        }

        public static IEnumerable<long> GetDivisors(this long number)
        {

            //yield return 1;
            for (long i = 1; i <= number / 2; i++)
            {
                if (number % i == 0) yield return i;
            }
            yield return number;
        }
        public static IEnumerable<long> GetReverseDivisors(this long number)
        {
            Contract.Requires<ArgumentOutOfRangeException>(number > 0);

            yield return number;
            for (long i = number / 2; i >= 2; i--)
            {
                if (number % i == 0) yield return i;
            }
            if (number != 1)
                yield return 1;
        }
        public static IEnumerable<short> GetDivisors(this short number)
        {
            Contract.Requires<ArgumentOutOfRangeException>(number > 0);

            for (short i = 1; i <= number / 2; i++)
            {
                if (number % i == 0) yield return i;
            }
            yield return number;
        }
        public static IEnumerable<int> GetDivisors(this int number)
        {
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0) yield return i;
            }
            yield return number;
        }

        public static bool IsPalindrome(this int number, int @base = 10)
        {
            Contract.Requires<ArgumentOutOfRangeException>(@base == 2 || @base == 8 || @base == 10 || @base == 16);

            var str1 = Convert.ToString(number, @base);
            var str2 = new string(str1.Reverse().ToArray());
            return str1 == str2;
        }

        public static IEnumerable<byte> GetDigits(this ulong number)
        {
            Contract.Requires<ArgumentOutOfRangeException>(number > 0);
            do
            {
                yield return (byte) (number % 10);
                number /= 10;
            } while (number > 0);
        }
    }
}
