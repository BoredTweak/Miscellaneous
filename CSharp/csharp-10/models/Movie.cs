namespace csharp_10
{
    /// <summary>
    /// A demonstration of C# 10's record struct feature via a Movie with a title and description
    /// </summary>
    internal readonly record struct Movie
    {
        internal string Title { get; init; }
        internal string Description { get; init; }

        internal Movie(string title, string description) => (Title, Description) = (title, description);
    }
}