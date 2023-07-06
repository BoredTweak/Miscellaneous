namespace csharp_9
{
    /// <summary>
    /// Pattern matching enhancements
    /// </summary>
    /// <link>https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#pattern-matching-enhancements</link>
    internal class PatternMatchingDemo
    {
        internal static void Run()
        {
            Console.WriteLine("Pattern matching enhancements");

            // Pattern matching is a feature that allows you to test an expression to see if it has a certain shape, and simultaneously
            // extract information from it. It is often used with the switch statement, but it can also be used with the if statement.
            // Pattern matching is useful for working with immutable data types, because it allows you to extract information from an
            // object without changing it.
            var job = new Job(Guid.NewGuid(), "Pasta Maker", "Bob");
            Console.WriteLine(job);

            // Pattern matching with the switch statement

            // The switch statement has been enhanced to allow you to use patterns in the case clauses. The following switch statement
            // uses a property pattern in the case clause to check if the job's title is "Pasta Maker".

            switch (job)
            {
                case { Title: "Pasta Maker" }:
                    Console.WriteLine("The job is a pasta maker.");
                    break;
                case { Title: "Spaghetti Engineer" }:
                    Console.WriteLine("The job is a spaghetti engineer.");
                    break;
                default:
                    Console.WriteLine("The job is something else.");
                    break;
            }

            // The switch statement has also been enhanced to allow you to use relational patterns in the case clauses. The following
            // switch statement uses a relational pattern in the case clause to check if the job's title is "Pasta Maker" or "Spaghetti Engineer".

            switch (job)
            {
                case { Title: "Pasta Maker" or "Spaghetti Engineer" }:
                    Console.WriteLine("The job is a pasta maker or a spaghetti engineer.");
                    break;
                default:
                    Console.WriteLine("The job is something else.");
                    break;
            }

            // The switch statement has also been enhanced to allow you to use logical patterns in the case clauses. The following
            // switch statement uses a logical pattern in the case clause to check if the job's title is "Pasta Maker" or "Spaghetti Engineer"
            // and the job's description is "Bob".

            switch (job)
            {
                case { Title: "Pasta Maker" or "Spaghetti Engineer", Description: "Bob" }:
                    Console.WriteLine("The job is a pasta maker or a spaghetti engineer, and the description is Bob.");
                    break;
                default:
                    Console.WriteLine("The job is something else.");
                    break;
            }

            // The switch statement has also been enhanced to allow you to use constant patterns in the case clauses. The following
            // switch statement uses a constant pattern in the case clause to check if the job's title is "Pasta Maker" or "Spaghetti Engineer"
            // and the job's description is "Bob" or "Alice".

            switch (job)
            {
                case { Title: "Pasta Maker" or "Spaghetti Engineer", Description: "Bob" or "Alice" }:
                    Console.WriteLine("The job is a pasta maker or a spaghetti engineer, and the description is Bob or Alice.");
                    break;
                default:
                    Console.WriteLine("The job is something else.");
                    break;
            }

            // The switch statement has also been enhanced to allow you to use type patterns in the case clauses. The following
            // switch statement uses a type pattern in the case clause to check if the job is a Job.

            switch (job)
            {
                case Job:
                    Console.WriteLine("The job is a job.");
                    break;
                default:
                    Console.WriteLine("The job is something else.");
                    break;
            }

            // The switch statement has also been enhanced to allow you to use var patterns in the case clauses. The following
            // switch statement uses a var pattern in the case clause to check if the job is a Job, and if it is, it assigns the job
            // to a variable named job2.

            switch (job)
            {
                case Job job2:
                    Console.WriteLine($"The job is a job. job2: {job2}");
                    break;
                default:
                    Console.WriteLine("The job is something else.");
                    break;
            }

            // The switch statement has also been enhanced to allow you to use positional patterns in the case clauses. The following
            // switch statement uses a positional pattern in the case clause to check if the job is a Job with a title of "Pasta Maker".

            switch (job)
            {
                case Job(_, "Pasta Maker", _):
                    Console.WriteLine("The job is a job with a title of Pasta Maker.");
                    break;
                default:
                    Console.WriteLine("The job is something else.");
                    break;
            }

            // The switch statement has also been enhanced to allow you to use relational patterns in the case clauses. The following
            // switch statement uses a relational pattern in the case clause to check if the job is a Job with a title of "Pasta Maker"
            // or "Spaghetti Engineer".

            switch (job)
            {
                case Job(_, "Pasta Maker" or "Spaghetti Engineer", _):
                    Console.WriteLine("The job is a job with a title of Pasta Maker or Spaghetti Engineer.");
                    break;
                default:
                    Console.WriteLine("The job is something else.");
                    break;
            }

            // The switch statement has also been enhanced to allow you to use logical patterns in the case clauses. The following
            // switch statement uses a logical pattern in the case clause to check if the job is a Job with a title of "Pasta Maker"
            // or "Spaghetti Engineer" and a description of "Bob".

            switch (job)
            {
                case Job(_, "Pasta Maker" or "Spaghetti Engineer", "Bob"):
                    Console.WriteLine("The job is a job with a title of Pasta Maker or Spaghetti Engineer and a description of Bob.");
                    break;
                default:
                    Console.WriteLine("The job is something else.");
                    break;
            }

            // The switch statement has also been enhanced to allow you to use constant patterns in the case clauses. The following
            // switch statement uses a constant pattern in the case clause to check if the job is a Job with a title of "Pasta Maker"
            // or "Spaghetti Engineer" and a description of "Bob" or "Alice".

            switch (job)
            {
                case Job(_, "Pasta Maker" or "Spaghetti Engineer", "Bob" or "Alice"):
                    Console.WriteLine("The job is a job with a title of Pasta Maker or Spaghetti Engineer and a description of Bob or Alice.");
                    break;
                default:
                    Console.WriteLine("The job is something else.");
                    break;
            }


            // Pattern matching with the if statement

            // The if statement has been enhanced to allow you to use patterns in the condition. The following if statement
            // uses a property pattern in the condition to check if the job's title is "Pasta Maker".

            if (job is { Title: "Pasta Maker" })
            {
                Console.WriteLine("The job is a pasta maker.");
            }
            else if (job is { Title: "Spaghetti Engineer" })
            {
                Console.WriteLine("The job is a spaghetti engineer.");
            }
            else
            {
                Console.WriteLine("The job is something else.");
            }

            // The if statement has also been enhanced to allow you to use relational patterns in the condition. The following
            // if statement uses a relational pattern in the condition to check if the job's title is "Pasta Maker" or "Spaghetti Engineer".

            if (job is { Title: "Pasta Maker" or "Spaghetti Engineer" })
            {
                Console.WriteLine("The job is a pasta maker or a spaghetti engineer.");
            }
            else
            {
                Console.WriteLine("The job is something else.");
            }

            // The if statement has also been enhanced to allow you to use logical patterns in the condition. The following
            // if statement uses a logical pattern in the condition to check if the job's title is "Pasta Maker" or "Spaghetti Engineer"
            // and the job's description is "Bob".

            if (job is { Title: "Pasta Maker" or "Spaghetti Engineer", Description: "Bob" })
            {
                Console.WriteLine("The job is a pasta maker or a spaghetti engineer, and the description is Bob.");
            }
            else
            {
                Console.WriteLine("The job is something else.");
            }


            // Pattern matching with the is operator

            // The is operator has been enhanced to allow you to use patterns in the condition. The following if statement
            // uses a property pattern in the condition to check if the job's title is "Pasta Maker".

            if (job is { Title: "Pasta Maker" })
            {
                Console.WriteLine("The job is a pasta maker.");
            }
            else if (job is { Title: "Spaghetti Engineer" })
            {
                Console.WriteLine("The job is a spaghetti engineer.");
            }
            else
            {
                Console.WriteLine("The job is something else.");
            }

            // The is operator has also been enhanced to allow you to use relational patterns in the condition. The following
            // if statement uses a relational pattern in the condition to check if the job's title is "Pasta Maker" or "Spaghetti Engineer".

            if (job is { Title: "Pasta Maker" or "Spaghetti Engineer" })
            {
                Console.WriteLine("The job is a pasta maker or a spaghetti engineer.");
            }
            else
            {
                Console.WriteLine("The job is something else.");
            }
        }

        internal static bool IsLetter(char c) => c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';

        internal static bool IsLetterOrSeparator(char c) => c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',';

        internal static bool IsLetterOrSeparatorOrDigit(char c) => c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',' or (>= '0' and <= '9');

    }
}