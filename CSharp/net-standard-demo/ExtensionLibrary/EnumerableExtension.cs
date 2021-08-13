using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionLibrary
{
    public static class EnumerableExtension
    {
        public static bool IsIn<T>(this T source, params T[] list)
        {
            if (null == source) throw new ArgumentNullException("source");
            return list.Contains(source);
        }

        public static readonly string[] SampleData = new string[]
        {
            "Example1",
            "Example2",
            "Example3",
            "Example4",
            "Example5",
            "Example6",
            "Example7",
            "Example8",
            "Example9",
            "Example10",
            "Example11",
            "Example12",
            "Example13",
            "Example14",
            "Example15",
            "Example16",
            "Example17",
            "NotExample"
        };
    }
}
