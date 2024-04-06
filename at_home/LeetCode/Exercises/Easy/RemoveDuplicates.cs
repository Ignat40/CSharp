using System.Globalization;

namespace LeetCode
{
    public class RemoveDuplicates
    {
        public int Remove(int[] nums)
        {
            int len = nums.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        for (int p = j; p < len - 1; p++)
                        {
                            nums[p] = nums[p + 1];
                        }
                        len--;
                        j--;
                    }

                }
            }
            Array.Resize(ref nums, len);
            foreach (var el in nums)
            {
                Console.WriteLine(el);
            }
            return len;
        }
    }
}