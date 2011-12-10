using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Diagnostics;

namespace P013
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var total = new BigInteger(0);

            foreach (var digit in Properties.Resources.digits.Split(
                Environment.NewLine.ToCharArray(), 
                StringSplitOptions.RemoveEmptyEntries
                ))
            {
                total += BigInteger.Parse(digit);
            }

            var result = total.ToString().Substring(0,10);
            Debug.Assert(result == "5537376230");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
