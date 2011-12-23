using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib;

namespace P024
{
    class P24
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            var target = 1000000UL - 1;
            var digits = "0123456789";

            for (int i = 9; i >= 1; i--) 
            {
                var iFact = i.FactorialSmall();
                var index = target / iFact;
                target = target % iFact;
                var digit = digits[(int)index];
                sb.Append(digit);
                digits = digits.Replace(digit.ToString(), "");
            }
            sb.Append(digits); // Add the last remaining digit

            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
