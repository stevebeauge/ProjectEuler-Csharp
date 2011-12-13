using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib
{
    public static class IntegerExtensions
    {
        public static bool IsEven(this int i)
        {
            return i%2==0;
        }
        public static bool IsOdd(this int i)
        {
            return !i.IsEven();
        }
        public static bool IsEven(this long i)
        {
            return i%2==0;
        }

        public static bool IsOdd(this long i)
        {
            return !i.IsEven();
        }       
    }
}
