using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Lib
{
    public sealed class Fibonacci
    {
        public static IEnumerable<BigInteger> FibonacciBig()
        {
            BigInteger x = new BigInteger(1);
            BigInteger y = x;
            BigInteger z;
            yield return x;
            yield return y;
            while (true)
            {
                z = x + y;
                yield return z;
                y=x;
                x=z;
            }
        }
        public static IEnumerable<long> FibonacciLong()
        {
            long x = 1L;
            long y = x;
            long z;
            yield return x;
            yield return y;
            while (true)
            {
                z = x + y;
                yield return z;
                y = x;
                x = z;
            }
        }

    }
}
