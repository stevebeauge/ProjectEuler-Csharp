using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib;
using Lib.Extentions;

namespace P037
{
    public class P37
    {
        static void Main()
        {
            var matching = from n in Prime.GetPrimes().SkipWhile(x=>x<23)
                           where n%10 != 1
                           where RightToLeftAreAllPrimes(n)
                           where LeftToRightAreAllPrimes(n)
                           select n;

            foreach (var item in matching.Take(11))
            {
                Console.WriteLine(item);
            }

            var result = matching.Take(11).Sum();

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static bool RightToLeftAreAllPrimes(ulong n)
        {
            do
            {
                n /= 10;
                if (!n.IsPrime()) return false;
            } while (n>0);
            return true; 
        }

        private static bool LeftToRightAreAllPrimes(ulong n)
        {
            var str = n.ToString();
            for (int i = 1; i < str.Length; i++)
            {
                var truncated = ulong.Parse(str.Substring(i));
                if (!truncated.IsPrime()) return false;
            }
            return true;
        }
    }
}
