using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P039
{
    public class P39
    {
        static void Main()
        {
            var maxCount = 0;
            var maxP = 0;
            for (var p = 3; p <= 1000; p++)
            {
                int count = 0;
                for (var a = 1; a <= p - 2; a++)
                {
                    for (var b = 1; b <= p - a - 1; b++)
                    {
                        var c = p - a - b;
                        if (a * a == b * b + c * c) // check if rectangle
                        {
                            count++;
                        }
                    }
                }
                if (count > maxCount)
                {
                    maxP = p;
                    maxCount = count;
                }
            }

            Console.WriteLine(maxP);
            Console.ReadLine();
        }
    }
}
