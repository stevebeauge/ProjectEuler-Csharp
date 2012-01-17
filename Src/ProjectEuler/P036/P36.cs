using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib.Extentions;

namespace P036
{
    public class P36
    {
        static void Main()
        {
            var sum = 0;
            for (int i = 0; i < 1000000; i++)
            {
                if (i.IsPalindrome(10) && i.IsPalindrome(2))
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
