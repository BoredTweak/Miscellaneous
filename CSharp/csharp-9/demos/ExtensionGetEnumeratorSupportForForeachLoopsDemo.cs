namespace csharp_9
{
    internal class ExtensionGetEnumeratorSupportForForeachLoopsDemo
    {
        /// <summary>
        /// Extension GetEnumerator support for foreach loops
        /// </summary>
        /// <link>https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#extension-getenumerator-support-for-foreach-loops</link>
        internal static void Run()
        {
            Console.WriteLine("Extension GetEnumerator support for foreach loops");

            // C# 9.0 adds support for extension GetEnumerator methods to be used in foreach loops.
            // This allows you to write custom enumerators for types that don't implement IEnumerable or IEnumerable<T>.
            Console.WriteLine("You can use iterate over items in a constructed enumerator.");
            var enumerator = new CustomEnumerator();
            foreach (var item in enumerator)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Or you can use the syntax `foreach (var item in new CustomEnumerator())`");
            foreach (var item in new CustomEnumerator())
            {
                Console.WriteLine(item);
            }
        }
    }
}