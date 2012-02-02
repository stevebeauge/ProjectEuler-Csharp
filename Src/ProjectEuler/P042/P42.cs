using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P042
{
    public class P42
    {
        static void Main()
        {
            var words = Properties.Resources.words.Split(',').Select(
                w=>w.Substring(1, w.Length -2) // Remove the surroundings quotes
                );

            var wordsAsCharPosSum = words.Select(
                w=> w.ToCharArray().Select(c=>(int)(c-'A' +1)).Sum() // Converts each letters to their positions and sum
                );

            var maxSumOfCharPos = wordsAsCharPosSum.Max(); // Max triangle number to calculate.

            var triangles = GetTrianglesUpTo(maxSumOfCharPos);

            var triangleWords = wordsAsCharPosSum.Where(
                sum=>triangles.Contains(sum)
                );

            Console.WriteLine(triangleWords.Count());

            Console.ReadLine();
        }

        private static IList<int> GetTrianglesUpTo(int maxSumOfCharPos)
        {
            var result = new List<int>();
            int tn;
            int n = 1;
            do
            {
                tn = n * (n + 1) / 2;
                result.Add(tn);
                n++;
            } while (tn<maxSumOfCharPos);
            return result;
        }
    }
}
