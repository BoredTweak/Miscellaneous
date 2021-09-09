using System;

namespace Fibonnaci
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = 15;
            if(args.Length > 0) 
            {
                int.TryParse(args[0], out var inputNumber);
                n = inputNumber;
            }

            Console.WriteLine($"Calculating Fibonacci for n = {n}");
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
