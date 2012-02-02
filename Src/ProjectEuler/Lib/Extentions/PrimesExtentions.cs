using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib.Extentions
{
    public static class PrimesExtentions
    {
        public static bool IsPrime(this ulong number)
        {
            return Primes.IsPrime(number);
        }
        public static bool IsPrime(this long number)
        {
            return Primes.IsPrime((ulong)number);
        }
        public static bool IsPrime(this uint number)
        {
            return Primes.IsPrime(number);
        }
        public static bool IsPrime(this int number)
        {
            return Primes.IsPrime((ulong)number);
        }
        public static bool IsPrime(this ushort number)
        {
            return Primes.IsPrime(number);
        }
        public static bool IsPrime(this short number)
        {
            return Primes.IsPrime((ulong)number);
        }

    }
}
