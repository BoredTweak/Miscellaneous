using System;

namespace Fibonnaci
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = 15;

            var output = Fibonacci.CalculateFib(n);
            Console.WriteLine($"Fibonacci {output}");

            var fib = new FibonacciCached();
            output = fib.CalculateFib(n);
            Console.WriteLine($"FibonacciCached {output}");

            var fibAsync = new FibonacciCachedAsync();
            output = fibAsync.CalculateFibAsync(n).Result;
            Console.WriteLine($"FibonacciCachedAsync {output}");

            Console.ReadLine();
        }
    }
}
