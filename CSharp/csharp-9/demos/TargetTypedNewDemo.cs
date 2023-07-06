namespace csharp_9
{
    internal class TargetTypedNewDemo
    {
        internal static void Run()
        {
            Console.WriteLine("Target-typed new expressions");

            // Target-typed new expressions allow you to omit the type name when creating a new object, as long as the type can be inferred from the context.
            // This is useful when you are creating a new object that implements an interface or is a subclass of another type.
            // The following line will not compile:
            // var job = new Job { Id = Guid.NewGuid(), Title = "Software Developer", Description = "Writes code" };

            // The following line will compile:
            Job job = new(Guid.NewGuid(), "Software Developer", "Writes code");
            Console.WriteLine(job);

            // Target-typed new expressions can also be used when creating arrays.
            // The following line will not compile:
            // var jobs = new Job[] { new Job { Id = Guid.NewGuid(), Title = "Software Developer", Description = "Writes code" } };

            // The following line will compile:
            List<Job> jobs = new() { new(Guid.NewGuid(), "Software Developer", "Writes code") };

            // Target-typed new expressions can also be used when creating anonymous types.
            // The following line will not compile:
            // var job2 = new { Id = Guid.NewGuid(), Title = "Software Developer", Description = "Writes code" };

            // The following line will compile:
            var job2 = new { Id = Guid.NewGuid(), Title = "Software Developer", Description = "Writes code" };
            Console.WriteLine(job2);

            // Target-typed new expressions can also be used when creating tuples.
            // The following line will not compile:
            // var job3 = (Guid.NewGuid(), "Software Developer", "Writes code");

            // The following line will compile:
            var job3 = (Id: Guid.NewGuid(), Title: "Software Developer", Description: "Writes code");
            Console.WriteLine(job3);

            // The following line will not compile:
            // var job4 = new Dictionary<Guid, Job> { { Guid.NewGuid(), new Job { Id = Guid.NewGuid(), Title = "Software Developer", Description = "Writes code" } } };

            // The following line will compile:
            var job4 = new Dictionary<Guid, Job> { { Guid.NewGuid(), new(Guid.NewGuid(), "Software Developer", "Writes code") } };
            Console.WriteLine(job4);
        }
    }
}