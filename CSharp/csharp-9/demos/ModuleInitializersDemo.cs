using System.Runtime.CompilerServices;

namespace csharp_9
{
    // <summary>
    // C# 9.0 adds the ability to declare a method as a module initializer.
    // This method will be called when the module is loaded.
    // </summary>
    // <link>https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/module-initializers</link>
    internal class ModuleInitializersDemo
    {
        [ModuleInitializer]
        internal static void Run()
        {
            Console.WriteLine("Module initializers");

            // C# 9.0 adds the ability to declare a method as a module initializer.
            // This method will be called when the module is loaded.
            // This is useful for initializing static fields in a thread-safe manner.
            // Note that this will only compile if the unsafe flag is set.
            // [ModuleInitializer]
            // internal static void Initialize()
            // {
            //     Console.WriteLine("Module initializer");
            // }
        }
    }
}