﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P030
{
    class P30
    {
        static void Main(string[] args)
        {

            Console.WriteLine("   Sum: " + GetMatchingNumbers(4).Sum());

            Console.WriteLine("   Sum: " + GetMatchingNumbers(5).Sum());
            Console.ReadLine();
        }

        static IEnumerable<int> GetMatchingNumbers(int power)
        {
            for (int i = 2; i <(power + 1)*(Math.Pow(9,power)); i++)
            {
                var sumOfPowers = 0;
                var tempi = i;
                while(tempi > 0)
                {
                    sumOfPowers += (int)Math.Pow( tempi % 10, power);
                    tempi /= 10;
                }
                if (sumOfPowers == i)
                {
                    yield return i;
                    Console.WriteLine("With Power {0}, {1} matches", power, i);
                }
            }
        }
    }
}
