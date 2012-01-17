using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P034
{
    public class P34
    {
        private static ulong[] g_SmallFactorials = new ulong[]  {
            1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880, 3628800, 39916800, 
            479001600, 6227020800, 87178291200, 1307674368000, 20922789888000, 
            355687428096000, 6402373705728000, 121645100408832000, 2432902008176640000 };

        static void Main()
        {
            ulong sum = 0;
            for (ulong i = 10; i < 9999999; i++)
            {
               if(IsCurious(i)) sum += i;
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }

        static bool IsCurious(ulong number)
        {
            ulong originalNumber = number;
            ulong sum = 0;
            do
            {
                sum += g_SmallFactorials[number % 10];
                if (sum > originalNumber) return false;
                number /= 10;
            } while (number > 0);

            return sum == originalNumber;
        }
    }
}
