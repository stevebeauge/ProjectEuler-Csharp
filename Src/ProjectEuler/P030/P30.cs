using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P030
{
    class P30
    {
        static void Main(string[] args)
        {
            foreach (var nbr in GetMatchingNumbers(5))
            {
                Console.WriteLine(nbr);
            }
            Console.WriteLine(GetMatchingNumbers(5).Sum());
            Console.ReadLine();
        }

        static IEnumerable<int> GetMatchingNumbers(int power)
        {
            for (int i = 2; i < 100000; i++)
            {
                var sumOfPowers = 0;
                var tempi = i;
                for (int x = 0; x < power; x++)
                {
                    sumOfPowers += (int)Math.Pow( tempi % 10, power);
                    tempi /= 10;
                }
                if(sumOfPowers == i) yield return i;
            }
        }
    }
}
