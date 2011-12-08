using System;
using System.Collections.Generic;
using System.Linq;

namespace P004
{
    class P004
    {
        static void Main(string[] args)
        {
            var r = from x in NumbersWithNDigits(3)
                    from y in NumbersWithNDigits(3) 
                    let p = x*y
                    let pStr = p.ToString()
                    where pStr == new string(pStr.Reverse().ToArray())
                    select new { x,y, p };

            Console.WriteLine(r.Max(s=>s.p));

            Console.ReadLine();
        }

        static IEnumerable<int> NumbersWithNDigits(int n)
        {
            int lBound =(int) Math.Pow(10,n-1);
            int uBound =(int) Math.Pow(10,n) -1;

            return Enumerable.Range(lBound, uBound - lBound + 1);
        }
    }
}
