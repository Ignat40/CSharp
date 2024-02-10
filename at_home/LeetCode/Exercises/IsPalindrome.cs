using System.Net.Http.Headers;

namespace LeetCode
{
    public class Palindrome
    {
        public static bool IsPalindrome(int x)
        {
            string input = x.ToString();
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] != input[input.Length - 1 - i])
                    return false;
            }
            return true;
           
        }
    }
}