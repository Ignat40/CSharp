namespace LeetCode;

public class Solution58
{
    public static int LenghtOfLastWord(string s)
    {
        // string[] words = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        // return words[^1].Length;
        //------------------------------
        // int count = 0; 
        // int length = s.Length - 1;

        // while(length >= 0 && s[length] == ' ')
        // {
        //     length--;
        // }
        // while(length >= 0 && s[length] != ' ')
        // {
        //     count++;
        //     length--;
        // }
        
        // return count;

        //------------------------------ best performance below

        int count = 0;
        bool flag = false; 

        for(int i = s.Length - 1; i >= 0; i--)
        {
            if(s[i] != ' ')
            {
                count++;
                flag = true;
            }
            else if(flag)
                break;

        }

        return count;
    }
}