using System;
using System.Diagnostics;
using System.Linq;
using Lib;
using Lib.Extentions;

namespace P003
{
    class P003
    {
        static void Main(string[] args)
        {
            var input = 600851475143;
            var primeFactors = input.GetPrimesFactor();
            foreach (var item in primeFactors)
            {
                Console.WriteLine(item);
            }

            Debug.Assert(primeFactors.Max() == 6857);

            Console.ReadLine();
        }

    }
}
