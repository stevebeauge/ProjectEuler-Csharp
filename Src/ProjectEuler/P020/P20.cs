using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib;

namespace P020
{
    class P20
    {
        static void Main(string[] args)
        {

            var result = 100.Factorial().ToString().Select(c => c - '0').Sum();

            Console.WriteLine(result);

            Console.ReadLine();

        }
    }
}
