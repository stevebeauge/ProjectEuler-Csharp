using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace P029
{
    class P29
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetCominations(5,5).Distinct().Count());
            Console.WriteLine(GetCominations(100,100).Distinct().Count());

            Console.ReadLine();
        }

        static IEnumerable<BigInteger> GetCominations(int maxA, int maxB)
        {
            for (int a = 2; a <= maxA; a++)
            {
                for (int b = 2; b <= maxB; b++)
                {
                    yield return BigInteger.Pow(a,b);
                }
            }
        }
    }
}
