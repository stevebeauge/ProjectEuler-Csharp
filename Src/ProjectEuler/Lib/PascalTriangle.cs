// Credit of the solution : http://blog.functionalfun.net/2008/07/project-euler-problem-15-city-grids-and.html
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib
{
    public static class PascalTriangle
    {
        public static long GetCellValue(int row, int col)
        {
            long current = 1;

            for (int i = 1; i <= col; i++)
            {
                current = (current * (row + 1 - i)) / i;
            }

            return current;
        }
    }
}
