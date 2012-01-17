using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib;

namespace P361
{
    class P361
    {
        const long uBound = 1000000000000000000;

        static readonly HashSet<long> AntiPatterns = PopulateAntiPatterns();

        private static HashSet<long> PopulateAntiPatterns()
        {
            long x111 = 7; // 111
            HashSet<long> result = new HashSet<long>();
            for (int i = 0; i < 64 - 3; i++)
            {
                result.Add(x111 << i);
            }
            long x101010 = 42; // 101010
            for (int i = 0; i < 64 - 6; i++)
            {
                result.Add(x101010 << i);
            }
            return result;
        } 

        static bool IsThueMorseCompliant(long number)
        {
            foreach (var pattern in AntiPatterns)
            {
                if ((number & pattern) > 0 || (~number & pattern) > 0)
                {
                    return false;
                }
            }
            return true;
        }
  
        static void Main(string[] args)
        {
            foreach (var item in ThueMorse().Take(10000))
            {
                Console.Write(item);
            }
            Console.ReadLine();
        }


        static IEnumerable<byte> ThueMorse()
        {
            var result = new List<byte>();
            yield return 0;
            yield return 1;
            result.Add(0);
            result.Add(1);
            int n = 2;
            while (true)
            {
                byte b1 = result[n / 2];
                result.Add(b1);
                byte b2 = (byte)(1 - result[n / (2-1)]);
                result.Add(b2);
                yield return b1;
                yield return b2;
                n += 2;
            }
        }

        struct x
        {
            int n;
            int An;
        }
    }
}
