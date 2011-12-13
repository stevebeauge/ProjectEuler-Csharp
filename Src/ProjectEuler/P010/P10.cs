using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib;

namespace P010
{
    class P10
    {
        static void Main(string[] args)
        {
            var primes = Prime.GetPrimes(2000000);
            ulong sum = 0;
            foreach (var p in primes)
            {
                sum += p;
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
