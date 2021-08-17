public class QuickSort 
{
    /// O(n * log n)     Quicksort
    /// Returns a sorted array
    /// Remark: Though there are many suggested partition schemes, we are demonstrating Lomuto partition scheme
    /// It is possible for this algorithm's worst case to reach O(n^2) comparisons
    /// https://en.wikipedia.org/wiki/Quicksort
    public static int[] Perform(int[] inputArray)
    {
        sort(inputArray, 0, inputArray.Length - 1);
        return inputArray;
    }

    private static void sort(int[] inputArray, int lowIndex, int highIndex)
    {
        if(inputArray.Length < 2)
        {
            return;
        }
        
        if(lowIndex >= 0 && highIndex >= 0 && lowIndex < highIndex)
        {
            var pivot = partition(inputArray, lowIndex, highIndex);
            sort(inputArray, lowIndex, pivot - 1);
            sort(inputArray, pivot + 1, highIndex);   
        }
    }

    private static int partition(int[] inputArray, int lowIndex, int highIndex)
    {
        int pivot = inputArray[highIndex];
        int index = lowIndex - 1;
        for(int j = lowIndex; j < highIndex; j++)
        {
            if(inputArray[j] <= pivot)
            {
                index = index + 1;
                Swap(inputArray, index, j);
            }
        }
        
        Swap(inputArray, index + 1, highIndex);
        return index + 1;
    }

    private static void Swap(int[] array, int index1, int index2)
    {
        int temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }
}
