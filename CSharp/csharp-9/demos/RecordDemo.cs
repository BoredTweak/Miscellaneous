namespace csharp_9
{
    /// <summary>
    /// Records are immutable objects that are used to store data. They are similar to classes, but they are immutable by default
    /// and they have value-based equality semantics. Records are reference types, but they are implemented as structs.
    /// </summary>
    /// <link>https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#records</link>
    internal class RecordDemo
    {
        internal static void Run()
        {
            Console.WriteLine("Records");

            // Records are immutable objects that are used to store data. They are similar to classes, but they are immutable by default 
            // and they have value-based equality semantics. Records are reference types, but they are implemented as structs.
            var job = new Job(Guid.NewGuid(), "Pasta Maker", "Bob");
            Console.WriteLine(job);

            // Records are immutable by default, so you can't change the properties of a record after it's created. The following line
            // will not compile:
            // job.Description = "Also Bob";

            // Records have value-based equality semantics, so two records are equal if their properties are equal.
            var job2 = new Job(job.Id, job.Title, job.Description);
            Console.WriteLine("Comparing two records:");
            Console.WriteLine(job);
            Console.WriteLine(job2);
            Console.WriteLine($"job == job2: {job == job2}");

            // Records have a positional deconstructor, so you can deconstruct a record without specifying the property names.
            var (id, title, description) = job2;
            Console.WriteLine($"Deconstructor: {id} {title} {description}");

            // Records have a with expression, so you can create a new record with the same properties as an existing record,
            // but with some properties changed.
            var job4 = job with { Title = "Spaghetti Engineer" };
            Console.WriteLine(job4);
        }
    }
}
