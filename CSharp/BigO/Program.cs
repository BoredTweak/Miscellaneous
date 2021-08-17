// Demonstrating Big O notation via algorithms.
/// O(n)            Linear search
/// O(log n)        Binary search
/// O(n * log n)    Quicksort
/// O(n^2)          Selection sort
/// O(n!)           Factorial

Console.WriteLine("--------------------------------------------------------------------");
Console.WriteLine("Search Algorithms");
Console.WriteLine("--------------------------------------------------------------------");

var inputArray = new int[] {1, 3, 5, 6, 12, 2, 65, 7, 11, 9};
var searchTarget = 9;

Console.WriteLine("-----------------");
Console.WriteLine("  Linear Search  ");
Console.WriteLine($"Given {string.Join(",", inputArray)} - Find the value {searchTarget}");
Console.WriteLine("-----------------");

Console.WriteLine(LinearSearch.Perform(inputArray, searchTarget));

var sortedArray = new int[] {1, 3, 5, 6, 12, 2, 65, 7, 11, 9};
Array.Sort(sortedArray);

Console.WriteLine("-----------------");
Console.WriteLine("  Binary Search  ");
Console.WriteLine($"Given {string.Join(",", sortedArray)} - Find the value {searchTarget}");
Console.WriteLine("-----------------");

Console.WriteLine(BinarySearch.Perform(sortedArray, searchTarget));

Console.WriteLine("-----------------");
Console.WriteLine(" Sort Algorithms ");
Console.WriteLine("-----------------");

Console.WriteLine("-----------------");
Console.WriteLine("   Quick Sort    ");
Console.WriteLine("-----------------");

Console.WriteLine(string.Join(",", QuickSort.Perform(new int[] {1, 3, 5, 6, 12, 2, 65, 7, 11, 9})));

Console.WriteLine("-----------------");
Console.WriteLine(" Selection Sort  ");
Console.WriteLine("-----------------");

Console.WriteLine(string.Join(",", SelectionSort.Perform(new int[] {1, 3, 5, 6, 12, 2, 65, 7, 11, 9})));

Console.WriteLine("-----------------");
Console.WriteLine("    Factorial   ");
Console.WriteLine("-----------------");

Console.WriteLine($"7! = {Factorial.Perform(7)}");
Console.WriteLine($"6! = {Factorial.Perform(6)}");
Console.WriteLine($"5! = {Factorial.Perform(5)}");
Console.WriteLine($"4! = {Factorial.Perform(4)}");
Console.WriteLine($"3! = {Factorial.Perform(3)}");
Console.WriteLine($"2! = {Factorial.Perform(2)}");
Console.WriteLine($"1! = {Factorial.Perform(1)}");
