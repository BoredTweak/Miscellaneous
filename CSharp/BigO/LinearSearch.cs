public class LinearSearch 
{
    /// O(n)     Linear search
    /// Returns the index of the array for which searchTarget is found, else returns null;
    /// No assumption that array is/is not sorted.
    /// https://en.wikipedia.org/wiki/Linear_search
    public static int? Perform(int[] inputArray, int searchTarget)
    {
        for(int index = 0; index < inputArray.Length; index++)
        {
            if(inputArray[index] == searchTarget)
            {
                return index;
            }
        }

        return null;
    }
}
