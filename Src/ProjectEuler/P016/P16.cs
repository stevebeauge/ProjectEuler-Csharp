using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace P016
{
    class P16
    {
        static void Main(string[] args)
        {
            var value = BigInteger.Pow(2,1000);
            Console.WriteLine( value.ToString().Select(c=>c-'0').Sum());

            Console.ReadLine();
        }
    }
}
