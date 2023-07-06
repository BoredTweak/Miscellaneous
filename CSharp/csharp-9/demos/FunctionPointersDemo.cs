namespace csharp_9
{
    /// <summary>
    /// Function pointers are a new kind of type in C# 9.0 that represent references to functions.
    /// </summary>
    /// <link>https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#function-pointers</link>
    internal class FunctionPointersDemo
    {
        internal static void Run()
        {
            Console.WriteLine("Function pointers");
            Console.WriteLine("Note that this will only compile with the unsafe keyword.");
            Console.WriteLine("See the source code for more information.");
            // Function pointers are a new kind of type in C# 9.0 that represent references to functions.
            // They are declared using the delegate* keyword.
            // Note that this will only compile with the unsafe keyword.
            // delegate*<int, void> f = &M;
            // f(42);

            // Use Cases for Function Pointers:
            // - Interop
            // - Pointer arithmetic
            // - Native APIs
        }

        // Note that this will only compile with the unsafe keyword.
        // internal static void Example(Action<int> a, delegate*<int, void> f) 
        // {
        //     a = f;
        // }
    }
}