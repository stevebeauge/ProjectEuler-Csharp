/* Thanks to http://stackoverflow.com/questions/8416395/possible-optimization-in-my-code */

using System;
using System.Diagnostics;
using System.Linq;
using Lib;

namespace P5
{
    class p5
    {
        const int maxNumber = 20;
        static void Main(string[] args)
        {

            long x = 1;
            for (int i = 2; i < maxNumber; i++)
            {
                x = Euclidean.Lcm(x, i);
            }
            Debug.Assert(x == 232792560);
            Console.WriteLine(x);

            Console.ReadLine();
        }


    }
}
