using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib;

namespace P014
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxLength = 0;
            var max = 0;
            for (int i = 1; i < 1000000; i++)
            {
                int length = Next(i);
                if (length > maxLength)
                {
                    max = i;
                    maxLength = length;
                }
            }

            Console.WriteLine("{0} : {1}", max, maxLength);

            Console.ReadLine();
        }

        static Dictionary<long, int> cache = new Dictionary<long, int>(); // For performance reason, cache results
        static int Next(long n)
        {
            if (cache.ContainsKey(n))
            {
                return cache[n];
            }
            else
            {
                int count;
                if (n == 1) count = 1;
                else if (n.IsEven()) count = Next(n / 2) + 1;
                else count = Next(3 * n + 1) + 1;
                cache.Add(n, count);
                return count;
            }
        }
    }
}
