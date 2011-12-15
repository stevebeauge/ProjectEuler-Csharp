using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib;
using System.Numerics;

namespace P025
{
    class P25
    {
        static void Main(string[] args)
        {
            int term = 0;

            foreach (var val in Fibonacci.FibonacciBig())
            {
                term++;
                if (val >= BigInteger.Pow(10, 999))
                {
                    Console.WriteLine(term);
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
