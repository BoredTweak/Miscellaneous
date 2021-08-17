public class SelectionSort 
{
    /// O(n^2)     Selection Sort
    /// Returns a sorted array
    /// https://en.wikipedia.org/wiki/Selection_sort
    public static int[] Perform(int[] inputArray)
    {
        for(int index = 0; index < inputArray.Length; index++)
        {
            int min = index;
            for(int j = index + 1; j < inputArray.Length; j++)
            {
                if(inputArray[j] < inputArray[min])
                {
                    min = j;
                }
            }

            if(min != index)
            {
                var temp = inputArray[index];
                inputArray[index] = inputArray[min];
                inputArray[min] = temp;
            }
        }

        return inputArray;
    }
}
