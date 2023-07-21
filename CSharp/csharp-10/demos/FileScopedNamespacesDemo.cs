namespace csharp_10;

/// <summary>
/// A demonstration of C# 10's file scoped namespaces feature
/// </summary>
/// <link>https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-10.0/file-scoped-namespaces</link>
internal class FileScopedNamespacesDemo
{
    internal static void Run()
    {
        Console.WriteLine("File Scoped Namespaces Demonstration");

        Console.WriteLine("This file is in the csharp_10 namespace leveraging the file scoped namespace feature.");

        Console.WriteLine();
    }
}
