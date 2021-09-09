using System;
using System.Collections.Concurrent;
using System.Numerics;
using System.Threading.Tasks;

namespace Fibonnaci
{
    public class FibonacciCachedAsync
    {
        ConcurrentDictionary<int, BigInteger> FibValues = new ConcurrentDictionary<int, BigInteger>();

        public async Task<BigInteger> CalculateFibAsync(int n)
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

            output = await CalculateFibAsync(n - 2) + await CalculateFibAsync(n - 1);
            FibValues.TryAdd(n, output);
            Console.WriteLine($"Input {n} - Output {output}");
            return output;
        }
    }
}
