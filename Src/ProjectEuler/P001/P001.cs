using System;
using System.Linq;

namespace P001
{
    class P001
    {
        static void Main()
        {
            var solution = Enumerable.Range(1, 999).Where(i => i % 3 == 0 || i % 5 == 0).Sum();

            Console.WriteLine(solution);
            Console.ReadLine();
        }
    }
}
