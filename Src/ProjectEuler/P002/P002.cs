using System;
using System.Collections.Generic;
using System.Linq;
using Lib;

namespace P002
{
    class P002
    {
        static void Main(string[] args)
        {
            var solution = Fibonacci.FibonacciLong()
                .TakeWhile(x=>x<4000000)
                .Where(i=>i%2==0)
                .Sum();

            Console.WriteLine(solution);
            Console.ReadLine();
        }


    }
}
