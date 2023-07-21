using System.Diagnostics.CodeAnalysis;

namespace csharp_10;

/// <summary>
/// A demonstration of C# 10's improvements to lambda expressions
/// </summary>
/// <link>https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#lambda-expression-improvements</link>
internal class LambdaImprovementsDemo
{
    internal static void Run()
    {
        Console.WriteLine("Lambda Improvements Demonstration");

        var numbers = new List<int> { 1, 2, 3, 4, 5 };

        // Lambda expressions may have a natural type, where the compiler can infer a delegate type from the lambda expression or method group.
        var evenNumbers = numbers.Where(n => n % 2 == 0);

        // Lambda expressions may declare a return type when the compiler can't infer it.
        var convertToFizzBuzz = object (int n) => n switch
        {
            int i when i % 15 == 0 => "FizzBuzz",
            int i when i % 3 == 0 => "Fizz",
            int i when i % 5 == 0 => "Buzz",
            _ => n
        };

        Console.WriteLine("Numbers converted to fizzbuzz:");
        foreach (var number in numbers)
        {
            Console.WriteLine(convertToFizzBuzz(number));
        }

        // Attributes can be applied to lambda expressions.
        var convertToRandomNumber = ([DisallowNull] int? n) =>
        {
            var random = new Random();
            return random.Next(1, n ?? 100);
        };

        Console.WriteLine();
    }
}