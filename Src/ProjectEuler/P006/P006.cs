using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P6
{
    class P6
    {
        static void Main(string[] args)
        {
            var squareOfSum = Math.Pow(Enumerable.Range(1, 100).Sum(),2);
            var sumOfSquare = Enumerable.Range(1, 100).Select(i => i*i).Sum();

            Console.WriteLine(squareOfSum - sumOfSquare);


            Console.ReadLine();
        }
    }
}
