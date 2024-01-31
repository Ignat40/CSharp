using System.Transactions;


// 49 ms 
namespace LeetCode
{
    public class ValidParentheses
    {
        Stack<char> charStack = new Stack<char>();
        public bool IsValid(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    charStack.Push(s[i]);

                }
                else if ((s[i] == ')' || s[i] == ']' || s[i] == '}') && charStack.Count != 0)
                {
                    if ((s[i] == ')' && charStack.Pop() != '(') ||
                         (s[i] == ']' && charStack.Pop() != '[') ||
                         (s[i] == '}' && charStack.Pop() != '{'))
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return charStack.Count == 0;
        }
    }
}

// solution for 34 ms (not mine )
public class Solution {
    public bool IsValid(string s) {
        // stack format of open brackets (FIFO system)
        Stack<char> OpenBrackets = new Stack<char>();
        foreach (char c in s)
        {
            char output;
            switch (c)
            {
                case '{': 
                    OpenBrackets.Push(c); 
                    break;
                case '[': 
                    OpenBrackets.Push(c); 
                    break;
                case '(': 
                    OpenBrackets.Push(c); 
                    break;
                case '}': 
                    if (OpenBrackets.Count == 0) { return false; }
                    if (OpenBrackets.Pop() != '{')  { return false; } 
                    break;
                case ']': 
                    if (OpenBrackets.Count == 0) { return false; }
                    if (OpenBrackets.Pop() != '[')  { return false; } 
                    break;
                case ')': 
                    if (OpenBrackets.Count == 0) { return false; }
                    if (OpenBrackets.Pop() != '(')  { return false; } 
                    break;
            }
        }
        if (OpenBrackets.Count == 0) { return true; } 
        return false;
    }
}