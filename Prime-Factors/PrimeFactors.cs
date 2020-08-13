using System.Collections.Generic;

namespace Prime_Factors
{
    public static class PrimeFactors
    {
        public static List<int> Of(int value)
        {
            var primes = new List<int>();
            for (int factor = 2; value > 1; factor++)
                for (; value % factor == 0; value /= factor)
                    primes.Add(factor);

            return primes;
        }
    }
}
