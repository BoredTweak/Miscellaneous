using System.Runtime.CompilerServices;

namespace csharp_10;

internal class CallerArgumentExpressionDemo
{
    /// <summary>
    /// A demonstration of C# 10's CallerArgumentExpression 
    /// </summary>
    /// <link>https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#callerargumentexpression-attribute-diagnostics</link>
    internal static void Run()
    {
        Console.WriteLine("Caller Argument Expression Demonstration");

        var movie = new Movie("The Matrix", "A movie about a computer hacker who learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.");

        movie.Title.ShouldBe("The Matrix Reloaded");

        movie.Description.ShouldBe("A movie about a computer hacker who learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.");

        Console.WriteLine();
    }


}