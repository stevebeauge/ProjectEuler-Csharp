using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Lib
{
    public class Grid2d
    {
        private int[,] m_Values;

        public static Grid2d Parse(string content)
        {
            var lines = content.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            var values = lines.Select(l=>l.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)).ToList();

            var result = new Grid2d();

            result.m_Values = new int[values.Count(), values.First().Count()];

            for (int i = 0; i < values.Count(); i++)
            {
                for (int j = 0; j < values.First().Count(); j++)
                {
                    result.m_Values[i, j] = int.Parse(values[i][j]);

                }
            }
            return result;
        }


        public int Width { get { return m_Values.GetLength(0); } }
        public int Height { get { return m_Values.GetLength(1); } }

        public int this[int x, int y]
        {
            get { return m_Values[x, y]; }
        }
    }
}
