using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeFactor
{
    public class PrimeFactorGenerator
    {
        public List<int> Generate(int n)
        {
            var primes = new List<int>();

            for (var candidate = 2; n > 1; candidate++)
                for (; n % candidate == 0; n /= candidate)
                    primes.Add(candidate);

            return primes;
        }
    }
}
