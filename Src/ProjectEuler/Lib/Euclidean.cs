using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib
{
    public static class Euclidean
    {
        public static int Gcd(int a, int b)
        {
            if (b == 0) return a;
            return Gcd(b, a - b * (a / b));
        }
        public static int Lcm(int a, int b)
        {
            return (a * b) / Gcd(a, b);
        }
        public static long Gcd(long a, long b)
        {
            if (b == 0) return a;
            return Gcd(b, a - b * (a / b));
        }
        public static long Lcm(long a, long b)
        {
            return (a * b) / Gcd(a, b);
        }

    }
}
