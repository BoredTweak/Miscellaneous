using ExtensionLibrary;
using System;
using System.Linq;

namespace FrameworkConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args == null || args.Count() < 1)
            {
                Console.WriteLine("Please provide input.");
                return;
            }

            Console.WriteLine(args[0].IsIn(EnumerableExtension.SampleData));
            Console.ReadLine();
        }
    }
}
