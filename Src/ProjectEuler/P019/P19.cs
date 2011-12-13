using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P019
{
    class P19
    {
        static void Main(string[] args)
        {
            var result = 0;
            for (DateTime date = new DateTime(1901, 1, 1); date < new DateTime(2000, 12, 31); date = date.AddMonths(1))
            {
                if (date.DayOfWeek == DayOfWeek.Sunday)
                {
                    result++;
                }
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
