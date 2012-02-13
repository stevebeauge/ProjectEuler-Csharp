using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Lib
{
    public static class Permutation
    {
        private static void Swap<T>(ref T[] array, int x, int y)
        {            
            T temp = array[x];
            array[x] = array[y];
            array[y] = temp;
        }

        private static IEnumerable<T[]> Go<T>(T[] array, int k, int m)
        {
            if (k == m)
            {
                yield return array;
            }
            else
            {
                for (int i = k; i <= m; i++)
                {
                    Swap(ref array, k, i);
                    foreach (var perm in Go(array, k + 1, m))
                    {
                        yield return perm;
                    }
                    Swap(ref array, k, i);
                }
            }
        }

        public static IEnumerable<T[]> Enumerate<T>(T[] array)
        {
            Contract.Requires<ArgumentNullException>(array != null);
            
            return Go(array, 0, array.Length - 1);
        }
    }
}
