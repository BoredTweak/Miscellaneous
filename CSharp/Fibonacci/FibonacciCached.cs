using System;
using System.Collections.Concurrent;
using System.Numerics;

namespace Fibonnaci
{
    public class FibonacciCached
    {
        ConcurrentDictionary<int, BigInteger> FibValues = new ConcurrentDictionary<int, BigInteger>();

        public BigInteger CalculateFib(int n)
        {
            if (FibValues.TryGetValue(n, out var output))
            {
                return output;
            }

            if (n < 2)
            {
                FibValues.TryAdd(n, n);
                return FibValues[n];
            }

            output = CalculateFib(n - 2) + CalculateFib(n - 1);
            FibValues.TryAdd(n, output);
            Console.WriteLine($"Input {n} - Output {output}");
            return output;
        }
    }
}