using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib;

namespace P076
{
    class P76
    {
        static void Main(string[] args)
        {
            long[] coins= new long[99];

            for (int i = 0; i < coins.Length; i++)
            {
                coins[i] = i + 1;
            }

            Console.WriteLine(
                CoinChangeAlgorithm.CountSolution(100, coins)
                );
            Console.ReadLine();

        }
    }
}
