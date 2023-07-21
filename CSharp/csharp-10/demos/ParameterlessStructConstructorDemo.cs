namespace csharp_10
{
    /// <summary>
    /// A demonstration of C# 10's parameterless and default record struct features via a Movie record
    /// </summary>
    /// <link>https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-10.0/record-structs</link>
    internal class ParameterlessStructConstructorDemo
    {
        internal static void Run()
        {
            Console.WriteLine("Parameterless Struct Constructor Demonstration");

            var movie = new Movie();
            Console.WriteLine(movie);
            Console.WriteLine(movie.Title);
            Console.WriteLine(movie.Description);

            var movie2 = movie with { Title = "The Matrix Reloaded" };
            Console.WriteLine(movie2);
            Console.WriteLine(movie2.Title);
            Console.WriteLine(movie2.Description);

            var movie3 = default(Movie);
            Console.WriteLine(movie3);
            Console.WriteLine(movie3.Title);
            Console.WriteLine(movie3.Description);

            Console.WriteLine($"Use cases of parameterless struct constructors: ");
            Console.WriteLine($"When you want to create a type that is immutable and lightweight.");

            Console.WriteLine();
        }
    }
}