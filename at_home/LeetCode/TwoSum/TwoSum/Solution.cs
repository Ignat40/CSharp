using System;

namespace LeetCode
{
    public class Solution
    {
        public static void Main()
        {
            int[] nums = { 1, 7, 11, 8 };
            int target = 9;
            int[] result = TwoSum(nums, target);

            if (result != null)
            {
                Console.WriteLine($"[{result[0]}, {result[1]}]");
            }
            else
            {
                Console.WriteLine("No valid solution found.");
            }
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            // Create a dictionary to store number complement and its index
            Dictionary<int, int> numDict = new Dictionary<int, int>();

            // Iterate through the array
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                // If complement exists in the dictionary, return indices
                if (numDict.ContainsKey(complement))
                {
                    return new int[] { numDict[complement], i };
                }

                // Add current number and its index to the dictionary
                if (!numDict.ContainsKey(nums[i]))
                {
                    numDict.Add(nums[i], i);
                }
            }

            // No valid solution found
            return null;
        }
    }
}
