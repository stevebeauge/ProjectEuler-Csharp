using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib;

namespace P067
{
    class P67
    {
        static void Main(string[] args)
        {
            var pyramid = PyramidNode.Load(Properties.Resources.PyramidP67);

            Console.WriteLine(pyramid.GetBestSum());

            Console.ReadLine();
        }
    }
}
