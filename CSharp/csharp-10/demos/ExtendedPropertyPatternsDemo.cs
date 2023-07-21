namespace csharp_10;

internal class ExtendedPropertyPatternsDemo
{
    /// <summary>
    /// A demonstration of C# 10's extended property patterns feature
    /// </summary>
    /// <link>https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-10.0/extended-property-patterns</link>
    internal static void Run()
    {
        Console.WriteLine("Extended Property Patterns Demonstration");

        var movie = new Movie("Some movie", "Very excite");

        Console.WriteLine($"The movie is {movie.Title} and the description is {movie.Description}");

        var cinema = new Cinema("Some Cinema", "Intense");

        Console.WriteLine($"The cinema is {cinema.Title} and the description is {cinema.Description}");

        var movieOrCinema = new object[] { movie, cinema };

        foreach (var item in movieOrCinema)
        {
            Console.WriteLine($"The item is a {(item is Movie { Title: "Some movie" } ? "movie" : "cinema")}");
        }

        Console.WriteLine($"Use cases of extended property patterns: ");
        Console.WriteLine($"When you want to match a property of an object in a pattern matching expression.");

        Console.WriteLine();
    }
}