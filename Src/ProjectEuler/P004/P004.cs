using System;
using System.Collections.Generic;
using System.Linq;

namespace P004
{
    class P004
    {
        private const int NumberOfDigits = 3;
        static void Main(string[] args)
        {
            var r = from x in NumbersWithNDigits(NumberOfDigits, (int)Math.Pow(10, NumberOfDigits - 1))
                    from y in NumbersWithNDigits(NumberOfDigits, x + 1) 
                    let p = x*y
                    let pStr = p.ToString()
                    where pStr == new string(pStr.Reverse().ToArray())
                    select new { x,y, p };

            Console.WriteLine(r.Max(s=>s.p));

            Console.ReadLine();
        }

        
        static IEnumerable<int> NumbersWithNDigits(int n, int lowerBound)
        {
            int upperBound =(int) Math.Pow(10,n) -1;

            return Enumerable.Range(lowerBound, upperBound - lowerBound + 1);
        }
    }
}
