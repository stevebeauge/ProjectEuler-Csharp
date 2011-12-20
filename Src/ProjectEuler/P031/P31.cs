using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib;

namespace P031
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                CoinChangeAlgorithm.CountSolution(200, 1, 2, 5 , 10, 20, 50, 100, 200)
                );
            Console.ReadLine();
        }
    }
}
