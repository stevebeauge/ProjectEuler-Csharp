using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib;

namespace P022
{
    class P22
    {
        static void Main(string[] args)
        {
            var nameScores = Properties.Resources.names.Split(
                new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries
                ).OrderBy(s=>s).SelectWithIndex((name, position) => Score(name, position));
            checked
            {
                Console.Write(nameScores.Sum());

            }

            Console.ReadLine();
        }

        private static long Score(string name, int position)
        {
            return name.Trim('"').ToCharArray().Select(c => c - 'A' + 1).Sum() * position;
        }
    }


}
