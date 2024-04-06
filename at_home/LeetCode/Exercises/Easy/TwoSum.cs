namespace LeetCode
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            if (target < Math.Pow(-10, 9) && target > Math.Pow(10, 9))
            {
                Console.WriteLine("Invalid input...");
                return Array.Empty<int>();
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine("Two sum found!");
                        Console.WriteLine($"Nums -> [{i}, {j}]");
                        return new int[] { i, j };
                    }
                }
            }

            Console.WriteLine("No such pair found...");
            return Array.Empty<int>();
        }
    }
}