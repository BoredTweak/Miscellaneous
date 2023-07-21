namespace csharp_10
{
    /// <summary>
    /// A demonstration of C# 10's Global using demo by referencing System.Math without a using statement
    /// </summary>
    /// <link>https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-directive#global-modifier</link>
    internal class GlobalUsingsDemo
    {
        internal static void Run()
        {
            Console.WriteLine("Global Usings Demonstration");

            Console.WriteLine($"The square root of 4 is {Sqrt(4)}");

            Console.WriteLine($"Use cases of global usings: ");
            Console.WriteLine($"When you want to use a type from a namespace without a using statement.");

            Console.WriteLine();
        }
    }
}