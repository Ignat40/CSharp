using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace LeetCode;

public class Solution35
{
    public static int SearchInsert(int[] nums, int target)
    {
        int position;

        for(int i = 0; i < nums.Length; i++)
        {
            if(target == nums[i])
            {
                position = i;
                return position;
            }
            else if(target < nums[i])
            {
                position = i;
                return position;
            }
            else if(target > nums[^1])
            {
                position = nums.Length;
                return position;
            }
            else
                continue;
        }

        return 0;
    }
}