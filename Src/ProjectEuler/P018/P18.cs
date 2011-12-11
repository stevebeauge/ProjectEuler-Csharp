using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib;

namespace P018
{
    class P18
    {
        static void Main(string[] args)
        {
            var pyramid = PyramidNode.Load(Properties.Resources.PyramidP18);

            Console.WriteLine(pyramid.GetBestSum());

            Console.ReadLine();
        }
    }
}
