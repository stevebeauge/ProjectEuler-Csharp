using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib;
using Lib.Extentions;

namespace P021
{
    class P21
    {
        static void Main(string[] args)
        {
            var divisors = new int[10000];

            for (int n = 0; n < divisors.Length; n++)
            {
                divisors[n] = (n+1).GetDivisors().Sum(); // +1 because the array is zero based, but we want to starts at 1
            }

            int sum = 0;
            for (int i1 = 1; i1 < divisors.Length; i1++)
            {
                for (int i2 = i1+1; i2 < divisors.Length +1; i2++)
                {
                    if (i1 == divisors[i2-1] && divisors[i1-1] == i2)
                    {
                        sum += i1 + i2;// +divisors[i2];
                    }
                }
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
