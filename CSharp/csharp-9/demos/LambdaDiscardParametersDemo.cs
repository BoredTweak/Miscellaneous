namespace csharp_9
{
    /// <summary>
    /// Lambda expressions, anonymous methods, and local functions can have discard parameters.
    /// </summary>
    /// <link>https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#lambda-expressions-anonymous-methods-and-local-functions-can-have-discard-parameters</link>
    internal class LambdaDiscardParametersDemo
    {
        internal static void Run()
        {
            // This is a lambda expression with a discard parameter.
            // The discard parameter is a placeholder for a parameter that is not used.
            // The discard parameter is
            // - a single underscore (_)


            // This is a lambda expression with a discard parameter.
            var expression = new System.Func<int, int, int>((_, _) => 1);
            Console.WriteLine($"Lambda Expression with discard: {expression(1, 2)}");

            // This is an anomymous method with a discard parameter.
            var anonymousMethod = delegate (int _, int _) { return 1; };
            Console.WriteLine($"Anonymous Method with discard: {anonymousMethod(1, 2)}");

            // This is a local function with a discard parameter.
            int LocalFunction(int _) => 1;
            Console.WriteLine($"Local Function with discard: {LocalFunction(20)}");

            // You cannot use a discard parameter in a method declaration.
            // void Method(int _) { }

            // You cannot use a discard parameter in a constructor declaration.
            // public Class(int _) { }

            // You cannot use a discard parameter in a destructor declaration.
            // ~Class(int _) { }

            // You cannot use multiple discard parameters in a local function.
            // int LocalFunction2(int _, int _) => 1;
        }
    }
}