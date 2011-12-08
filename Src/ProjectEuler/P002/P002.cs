using System;
using System.Collections.Generic;
using System.Linq;

namespace P002
{
    class P002
    {
        static void Main(string[] args)
        {
            var solution = Fib().Where(i=>i%2==0).Sum();

            Console.WriteLine(solution);
            Console.ReadLine();
        }


        static IEnumerable<long> Fib()
        {
            long x = 0;
            long y = 1;
            long r;

            while ((r = x + y) < 4000000)
            {
                Console.WriteLine("{0,7} + {1,7} = {2,7}", x, y, r);
                yield return r;
                x = y;
                y = r;
            } 
            
        }
    }
}
