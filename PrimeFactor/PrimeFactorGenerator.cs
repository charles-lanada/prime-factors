using System.Collections.Generic;

namespace PrimeFactor
{
    public class PrimeFactorGenerator
    {
        public List<int> Generate(int n)
        {
            var primes = new List<int>();

            for (var smallestPrime = 2; n > 1; smallestPrime++)
                for (; n % smallestPrime == 0; n /= smallestPrime)
                    primes.Add(smallestPrime);

            return primes;
        }
    }
}
