namespace csharp_9
{
    /// <summary>
    /// Native sized integers
    /// </summary>
    /// <link>https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types</link>
    internal class NativeSizedIntegersDemo
    {
        internal static void Run()
        {
            // Native sized integer
            nint nativeSizedInteger = 1;
            Console.WriteLine($"Native sized integer: {nativeSizedInteger}");
            Console.WriteLine($"Native sized integer type: {nativeSizedInteger.GetType()}");

            // Note that this is only possible with the unsafe keyword.
            // Console.WriteLine($"Native sized integer size: {sizeof(nint)}");

            // Native unsigned sized integer
            nuint nativeUnsignedSizedInteger = 1;
            Console.WriteLine($"Native unsigned sized integer: {nativeUnsignedSizedInteger}");
            Console.WriteLine($"Native unsigned sized integer type: {nativeUnsignedSizedInteger.GetType()}");

            // Note that this is only possible with the unsafe keyword.
            // Console.WriteLine($"Native unsigned sized integer size: {sizeof(nuint)}");

            // Use cases for native sized integers:
            // - Interop
            // - Pointer arithmetic
            // - Native APIs
        }
    }
}