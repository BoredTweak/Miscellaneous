namespace LeetCode;

public static class TwoSums {
    public static int[] Run(int[] nums, int target)
    {
        for(int i = 0; i < nums.Length - 1; i++) 
        {
            for (int j = i + 1; j <= nums.Length - 1; j++)
            {
                if(j == i) 
                {
                    continue;
                }

                if(nums[i] + nums[j] == target) 
                {
                    return new int[] { i, j };
                }
            }
        }

        return new int[] {};
    }

    /// <summary>
    /// Leverages a Dictionary to store the complement of the current number
    /// Note that this solution fails if the nums array contains duplicate numbers
    /// </summary>
    public static int[] RunWithHashMap(int[] nums, int target)
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        Dictionary<int, int> map = new Dictionary<int, int>(nums.Length);

        for(int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if(map.TryGetValue(complement, out int mapComplement))
            {
                return new int[] { mapComplement, i };
            }

            map.TryAdd(nums[i], i);
        }

        return Array.Empty<int>();
    }
}