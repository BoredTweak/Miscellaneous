namespace csharp_10;

internal class InterpolatedStringImprovementsDemo
{
    /// <summary>
    /// A demonstration of string interpolation improvements. In C# 10, const strings may be initialized using string interpolation if all the placeholders are themselves constant strings.
    /// </summary>
    /// <link>https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#constant-interpolated-strings</link>
    internal static void Run()
    {
        Console.WriteLine("Interpolated String Improvements Demonstration");

        const string name = "John";
        const string message = $"Hello, {name}!";

        Console.WriteLine(message);

        Console.WriteLine($"Use cases of interpolated string improvements: ");
        Console.WriteLine($"When you want to initialize a const string using string interpolation.");

        Console.WriteLine();
    }
}