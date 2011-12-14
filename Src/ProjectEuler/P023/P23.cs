using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib;

namespace P023
{
    class P23
    {
        const int lBound = 12;
        const int uBound = 28123;
        enum Qualification { None=0, Perfect, Deficient, Abundant }
        static void Main(string[] args)
        {
            int result;
            Console.WriteLine(
                "Solution computed in {0}",
                FrameworkUtilities.Measure(() =>
                {
                    var qualifications = new Qualification[uBound - lBound + 1];
                    for (int i = lBound; i <= uBound ; i++)
                    {
                        qualifications[i - lBound] = GetQualification(i);
                    }

                    var abundants = qualifications.SelectWithPosition(
                        (q, i) => new { q, Nbr= i+lBound-1}
                        ).Where(a=>a.q == Qualification.Abundant).Select(a=>a.Nbr).ToList();
                    var crossSumOfAbundants = from x1 in abundants
                                              from x2 in abundants
                                              select x1 + x2;
                    
                    var excepts = Enumerable.Range(1, uBound).Except(crossSumOfAbundants);
                    return excepts.Sum();

                }, 
                out result));
            Console.WriteLine(result);

            Console.ReadLine();
        }

        private static Qualification GetQualification(int i)
        {
            var divisorsSum = i.GetDivisors().Sum();

            if (divisorsSum == i) return Qualification.Perfect;
            else if (divisorsSum < i) return Qualification.Deficient;
            else return Qualification.Abundant;
              
        }

        private static IEnumerable<int> GetAbundant(int min = lBound, int max=uBound -lBound +1)
        {
            for (int i = min; i <= max; i++)
            {
                var iQual = GetQualification(i);
                if (iQual == Qualification.Abundant) yield return i;
            }

        }
    }
}
