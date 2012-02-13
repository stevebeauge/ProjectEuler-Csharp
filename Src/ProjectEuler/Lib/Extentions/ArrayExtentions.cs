using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics.Contracts;

namespace Lib.Extentions
{
    public static class ArrayExtentions
    {
        public static IEnumerable<T[]> GetPermutations<T>(this T[] source)
        {
            return Permutation.Enumerate(source);
        }
    }
}
