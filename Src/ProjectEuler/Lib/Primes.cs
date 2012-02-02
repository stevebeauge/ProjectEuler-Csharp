using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics.Contracts;

namespace Lib
{
    public static class Primes
    {
        private static ulong g_MaxTested;
        private static ulong g_MaxFound;

        private static readonly HashSet<ulong> g_KnownPrimes;

        static Primes()
        {
            // All primes below 1000 (http://en.wikipedia.org/wiki/Primes)
            g_KnownPrimes = new HashSet<ulong>() {
                2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 
                79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 
                167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227, 229, 233, 239, 241, 251, 
                257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 
                353, 359, 367, 373, 379, 383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 443, 
                449, 457, 461, 463, 467, 479, 487, 491, 499, 503, 509, 521, 523, 541, 547, 557, 
                563, 569, 571, 577, 587, 593, 599, 601, 607, 613, 617, 619, 631, 641, 643, 647, 
                653, 659, 661, 673, 677, 683, 691, 701, 709, 719, 727, 733, 739, 743, 751, 757, 
                761, 769, 773, 787, 797, 809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 
                877, 881, 883, 887, 907, 911, 919, 929, 937, 941, 947, 953, 967, 971, 977, 983, 
                991, 997
            };

            g_MaxTested = 997;
            g_MaxFound = 997;
            
        }

        private static void EnsureExploredUpTo(ulong upperBound)
        {
            if (upperBound <= g_MaxTested) return;

            for (g_MaxTested += 2; g_MaxTested <= upperBound; g_MaxTested += 2)
            {
                if (TestPrimality(g_MaxTested))
                {
                    g_KnownPrimes.Add(g_MaxTested);
                    g_MaxFound = g_MaxTested;
                }
            }
        }

        private static bool TestPrimality(ulong value)
        {
            if (value == 1) return false;
            var sqrt = (ulong)Math.Sqrt(value);
            return !g_KnownPrimes
                .TakeWhile(x => x <= sqrt)
                .Any(x => value % x == 0);
        }

        public static bool IsPrime(ulong value)
        {
            if (value == 1) return false;
            EnsureExploredUpTo(value);
            return g_KnownPrimes.Contains(value);
        }

        public static IEnumerable<ulong> GetPrimes(ulong upperBound = ulong.MaxValue)
        {
            // First return all known primes : 
            foreach (var prime in g_KnownPrimes)
            {
                if (prime > upperBound) yield break;
                yield return prime;
                
            }
            // then, if required, continue exploring :
            for (g_MaxTested += 2; g_MaxTested <= upperBound; g_MaxTested += 2)
            {
                if (TestPrimality(g_MaxTested))
                {
                    g_KnownPrimes.Add(g_MaxTested);
                    g_MaxFound = g_MaxTested;
                    yield return g_MaxTested; // yield the result for immediate use
                }
            }

        }
    }
}
