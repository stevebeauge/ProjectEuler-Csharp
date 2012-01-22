using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib.Extentions;

namespace P032
{
    public class P32
    {
        static void Main()
        {
            var digits = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var matching = new HashSet<int>();

            var perms = digits.GetPermutations();
            Action<int[], int,int> a = (perm, i, j) =>
            {
                var multiplicand = DigitsToInt(perm, 0, i - 1);
                var multiplier = DigitsToInt(perm, i, i + j - 1);
                var product = DigitsToInt(perm, i + j, perm.Length - 1);

                if (multiplicand * multiplier == product)
                {
                    matching.Add(product);
                }
            };
            foreach (var perm in perms)
            {
                var permArray = perm.ToArray();
                a(permArray,1, 4);
                a(permArray,2, 3);
            }

            Console.WriteLine(matching.Sum());
            Console.ReadLine();
        }

        static int DigitsToInt(int[] digits, int lBound, int uBound)
        {
            var result = 0;
            for (int i = lBound; i < uBound; i++)
            {
                result += digits[i];
                result *= 10;
            }
            result += digits[uBound];
            return result;
        }
    }
}
