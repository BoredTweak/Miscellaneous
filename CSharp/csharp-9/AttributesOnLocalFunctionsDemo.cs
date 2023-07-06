namespace csharp_9
{
    /// <summary>
    /// Attributes on local functions
    /// </summary>
    /// <link>https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#attributes-on-local-functions</link>
    internal class AttributesOnLocalFunctionsDemo
    {
        internal static void Run()
        {
            Console.WriteLine("Attributes on local functions");

            // You can apply attributes to local functions.
            [Obsolete]
            void LocalFunction() => Console.WriteLine("Local function with attribute was called!");

            // Note that the attribute is applied to the local function and intellisense will show the attribute.
            LocalFunction();

            // You can not apply attributes to local delegates.
            // This will not compile:
            // [Obsolete]
            // Action localDelegate = () => Console.WriteLine("Local delegate with attribute was called!");

            // You can apply attributes to anonymous methods.
            // This will not compile:
            // [Obsolete]
            // var anonymousMethod = delegate (int _, int _) { return 1; };
        }
    }
}