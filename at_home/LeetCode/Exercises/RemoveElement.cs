/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

namespace LeetCode
{

    public class RemoveElement
    {
        public static int RemEl(int[] nums, int val)
        {
            int newSize = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != val)
                {
                    nums[newSize] = nums[i];
                    newSize++;
                }
            }

            Array.Resize(ref nums, newSize);

            foreach(var num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            return nums.Length;
        }
    }

}
