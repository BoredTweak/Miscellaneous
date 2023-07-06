namespace csharp_9
{
    /// <summary>
    /// Covariant return types enable you to override a method and return a more derived type than that specified in the overridden method.
    /// </summary>
    /// <link>https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#covariant-return-types</link>
    internal class CovariantReturnTypesDemo
    {
        internal static void Run()
        {
            Console.WriteLine("Covariant return types");

            // Covariant return types enable you to override a method and return a more derived type than that specified in the overridden method.
            // This enables you to model more specific return types in your class hierarchy.
            // The following example shows a base class that defines a virtual method that returns an object, and a derived class that overrides
            // the method and returns a string.
            var baseClass = new BaseClass();
            Console.WriteLine($"Base Class Some Method: {baseClass.SomeMethod()}");

            var derivedClass = new DerivedClass();
            Console.WriteLine($"Derived Class Some Method: {derivedClass.SomeMethod()}");
        }
    }
}