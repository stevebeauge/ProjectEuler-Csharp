using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib;
using Lib.Extentions;

namespace P035
{
    public class P35
    {
        static void Main()
        {

            var primes = Prime.GetPrimes(999999);
            var circularPrimes = primes.Where(u => IsCircular(u));

            foreach (var item in circularPrimes)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(circularPrimes.Count());

            Console.ReadLine();
        }

        static bool IsCircular(ulong number)
        {
            return number.ToString().GetRotations().Select(
                s => ulong.Parse(new string(s.ToArray()))
                ).All(u=>Prime.IsPrime(u));
        }
    }
}
