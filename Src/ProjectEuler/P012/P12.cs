using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib;

namespace P012
{
    class P12
    {
        static void Main(string[] args)
        {
            var triangles = Numbers.GetTriangleNumbersInt64();

            foreach (var triangle in triangles.Skip(1)) // Skip number 1
            {
                var primesFactors = triangle.GetPrimesFactor();
                if(primesFactors.Count()==0) continue;

                // Count of divisor is equals to the product of primes factor powers
                // http://mathforum.org/library/drmath/view/55843.html for explanations
                var grouped = primesFactors.GroupBy(x=>x).Select(x=>new { X= x.Key, Pow = x.Count()});
                var divisorCount = grouped.Select(x=>x.Pow+1).Aggregate((x,y)=>x*y);

                if (divisorCount > 500)
                {
                    Console.WriteLine(triangle);
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
