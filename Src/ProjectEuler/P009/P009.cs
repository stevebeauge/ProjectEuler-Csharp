using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P9
{
    public class p9
    {
        static void Main()
        {
            Console.WriteLine(Explore());

            Console.ReadLine();
        }

        private static int Explore()
        {
            for (int a = 1; a < 998; a++)
            {
                for (int b = a + 1; b < 998; b++)
                {
                    var c = 1000 - a - b;
                    if (a * a + b * b == c * c)
                    {
                        return a * b * c;
                    }
                }
            }
            throw new InvalidProgramException("No answer");
        }
    }
}
