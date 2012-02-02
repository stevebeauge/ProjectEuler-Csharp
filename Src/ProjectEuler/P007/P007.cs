using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Lib;

namespace P7
{
    class p7
    {
        static void Main(string[] args)
        {
            var i = Primes.GetPrimes().Skip(10000).First();

            Debug.Assert(i == 104743);
            Console.WriteLine(i);
            
            Console.ReadLine();
        }

    }
}
