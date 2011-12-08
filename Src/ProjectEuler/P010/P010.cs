using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib;

namespace P0010
{
    class P0010
    {
        static void Main(string[] args)
        {
            var primes = Prime.GetPrimes(2000000);
            long sum = 0;
            foreach (var p in primes)
            {
                sum += p;
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
