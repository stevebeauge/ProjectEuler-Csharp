/*
 * Brute force solution, but a nice analytics solution exists :
 * http://www.mathblog.dk/project-euler-43-pandigital-numbers-sub-string-divisibility/
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Lib.Extentions;

namespace P043
{
    public class P43
    {
        static void Main()
        {
            var digits = new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var digitsPermutations = digits.GetPermutations()
                .Select(perm=>perm);

            var matchings = digitsPermutations
                .Where(perm => Test(perm))
                .Select(perm=>DigitsToInt(perm));

            ulong result = 0;
            foreach (var item in matchings)
            {
                    result += item;
            }
            Console.WriteLine(result);

            Console.ReadLine();
        }

        static readonly int[] divisors = { 1, 2, 3, 5, 7, 11, 13, 17 };

        private static bool Test(byte[] perm)
        {
            for (int k = 1; k < divisors.Length; k++)
            {
                int num = 100 * perm[k] + 10 * perm[k + 1] + perm[k + 2];
                if (num % divisors[k] != 0)
                {
                    return false;
                }
            }
            return true;
        }
        static uint DigitsToInt(byte[] digits, int firstDigitPosition, int lastDigitPosition)
        {
            var result = 0U;
            for (int i = firstDigitPosition; i < lastDigitPosition; i++)
            {
                result += digits[i-1];
                result *= 10;
            }
            result += digits[lastDigitPosition-1];
            return result;
        }
        static uint DigitsToInt(byte[] digits)
        {
            return DigitsToInt(digits, 1, digits.Length);
        }

    }
}
