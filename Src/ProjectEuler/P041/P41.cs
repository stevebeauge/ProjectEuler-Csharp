using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib;
using Lib.Extentions;

namespace P041
{
    public class P41
    {
        static void Main()
        {

            var permutations = (
                        from n in new int[] { 7, 4, 1}// other values not possible as the sum of all digits is multiple of 3
                        let digits = DigitArray(n)
                        select digits.GetPermutations()
                ).SelectMany(x => x);

            var solution =
                        from perm in permutations
                        let permArr = perm.ToArray()
                        let lastDigit = permArr[permArr.Length - 1]
                        where lastDigit != 2 && lastDigit != 5
                        let number = DigitsToInt(permArr)
                        where number.IsPrime()
                        select number;


            Console.WriteLine(solution.First());

            Console.ReadLine();
        }

        private static int[] DigitArray(int length)
        {
            var digits = new int[length];
            for (int d = 1; d <= digits.Length; d++)
            {
                digits[digits.Length - d] = d;
            }
            return digits;
        }
        static void Main2()
        {
            // Get all primes with 9 digits
            //var primes = Prime.GetPrimes().SkipWhile(p => p < 1000000000).TakeWhile(p=>p<10000000000).Reverse();
            for (ulong i = 999999999; 
                       i > 100000000; 
                       i-=2)
            {              
                if (!i.IsPrime()) continue;

                var digits = i.GetDigits();
                var digitMask = new bool[10];
                foreach (var digit in digits)
                {
                    digitMask[digit] = true;
                }

                if (
                    digitMask[1] && digitMask[2] &&digitMask[3] 
                    && digitMask[4] &&digitMask[5] && digitMask[6] 
                    &&digitMask[7] && digitMask[8] &&digitMask[9])
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            Console.WriteLine("..." );
            Console.ReadLine();
        }

        static int DigitsToInt(int[] digits)
        {
            var result = 0;
            for (int i = 0; i < digits.Length -1; i++)
            {
                result += digits[i];
                result *= 10;
            }
            result += digits[digits.Length - 1];
            return result;
        }

    }
}
