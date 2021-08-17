public class BinarySearch 
{
    /// O(log n)     Binary search
    /// In this example we're using `null` for unsuccessful search.
    /// Returns the index of the array for which searchTarget is found, else returns null;
    /// Assumption: Array is sorted before entering this method.
    /// https://en.wikipedia.org/wiki/Binary_search_algorithm
    public static int? Perform(int[] inputArray, int searchTarget)
    {
        int left = 0;
        int right = inputArray.Length - 1;
        while( left <= right )
        {
            int attempt = (left + right) / 2;
            if(inputArray[attempt] < searchTarget)
            {
                left = attempt + 1;
            }
            else if (inputArray[attempt] > searchTarget)
            {
                right = attempt - 1;
            }
            
            return attempt;
        }

        return null;
    }
}
