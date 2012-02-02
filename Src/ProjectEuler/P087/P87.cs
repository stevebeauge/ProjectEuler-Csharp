using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using Lib;

namespace P087
{
    class P87
    {
        const ulong uBound = 50000000;
        static void Main(string[] args)
        {

            var primesPow2 = Primes.GetPrimes((ulong)Math.Pow(uBound, 1 / 2D)).ToArray();
            var primesPow3 = Primes.GetPrimes((ulong)Math.Pow(uBound, 1 / 3D)).ToArray();
            var primesPow4 = Primes.GetPrimes((ulong)Math.Pow(uBound, 1 / 4D)).ToArray();
            var matching = new HashSet<ulong>();
            for (int pow4idx = 0; pow4idx < primesPow4.Length; pow4idx++)
            {
                var pow4 = (ulong)Math.Pow(primesPow4[pow4idx], 4);
                for (int pow3idx = 0; pow3idx < primesPow3.Length; pow3idx++)
                {
                    var pow3 = (ulong)Math.Pow(primesPow3[pow3idx], 3);
                    if (pow4 + pow3 >= uBound) break;
                    for (int pow2idx = 0; pow2idx < primesPow2.Length; pow2idx++)
                    {
                        var pow2 = (ulong)Math.Pow(primesPow2[pow2idx], 2);
                        ulong candidate = pow2 + pow3 + pow4;
                        if (candidate > uBound)
                        {
                            break;
                        }
                        matching.Add(candidate);
                    }
                }
            }

            Console.WriteLine(matching.Count);
            Console.ReadLine();
        }
        //static void Main(string[] args)
        //{

        //    var primes = Prime.GetPrimes((ulong)Math.Sqrt(uBound)).ToList();

        //    var primesPower = new ulong[primes.Count, 3];

        //    for (int i = 0; i < primes.Count; i++)
        //    {
        //        primesPower[i, 0] = (ulong)Math.Pow(primes[i], 2);
        //        primesPower[i, 1] = (ulong)Math.Pow(primes[i], 3);
        //        primesPower[i, 2] = (ulong)Math.Pow(primes[i], 4);
        //    }

        //    uint count = 0;
        //    for (int pow2idx = 0; pow2idx < primes.Count; pow2idx++)
        //    {
        //        var pow2 = primesPower[pow2idx, 0];
        //        for (int pow3idx = 0; pow3idx < primes.Count; pow3idx++)
        //        {
        //            var pow3 = primesPower[pow3idx, 1];
        //            if(pow2 + pow3 >= uBound) break;
        //            for (int pow4idx = 0; pow4idx < primes.Count; pow4idx++)
        //            {
        //                var pow4 = primesPower[pow4idx, 2];
        //                if (pow2 + pow3 + pow4 <= uBound)
        //                {
        //                    count++;
        //                    break;
        //                }

        //            }
        //        }
        //    }

        //    Console.WriteLine(count);
        //    Console.ReadLine();
        //}
    }
}
