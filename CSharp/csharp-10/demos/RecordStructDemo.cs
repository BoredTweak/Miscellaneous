namespace csharp_10
{
    /// <summary>
    /// A demonstration of C# 10's record struct feature via a Movie with a title and description
    /// </summary>
    /// <link>https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-10.0/record-structs</link>
    internal class RecordStructDemo
    {
        internal static void Run()
        {
            Console.WriteLine("Record Struct Demonstration");

            var movie = new Movie("The Matrix", "A movie about a computer hacker who learns about the true nature of his reality.");
            Console.WriteLine(movie);
            Console.WriteLine(movie.Title);
            Console.WriteLine(movie.Description);

            var movie2 = movie with { Title = "The Matrix Reloaded" };
            Console.WriteLine(movie2);
            Console.WriteLine(movie2.Title);
            Console.WriteLine(movie2.Description);

            Console.WriteLine($"Use cases of record structs: ");
            Console.WriteLine($"When you want to create a type that is immutable and lightweight.");

            Console.WriteLine();
        }
    }
}