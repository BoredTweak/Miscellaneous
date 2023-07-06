namespace csharp_9
{
    /// <summary>
    /// Init-only properties
    /// </summary>
    /// <link>https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#init-only-properties</link>
    internal class InitOnlyDemo
    {
        internal static void Run()
        {
            Console.WriteLine("Init-only properties");

            // Init-only properties are properties that can only be set in the constructor of a class or struct, or in an object initializer.
            // They are useful for immutable objects, because they allow you to set the properties of an object in the constructor, but not
            // change them later.
            var report = new FieldReport
            {
                Date = DateTime.Now,
                Temperature = 23.5m,
                Humidity = 0.45m
            };
            Console.WriteLine(report);

            // Init-only properties can't be changed after the object is created. The following line will not compile:
            // report.Temperature = 24.5m;

            // Init-only properties can be set in the constructor of a class or struct, or in an object initializer.
            // The following line will not compile:
            // var report2 = new FieldReport();
            // report2.Date = DateTime.Now;
            // report2.Temperature = 23.5m;
            // report2.Humidity = 0.45m;
        }
    }
}