using System.Globalization;
using System.Net.Http.Headers;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

namespace LeetCode;

public class RomanToInt
{
    public static int romanToInt(string s)
    {
        string str = s.ToUpper();

        Dictionary<char, int> roman = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };

        int total = 0;
        char lastChar = str[str.Length - 1];

        for(int i = 0; i < str.Length - 1; i++)
        {
            if(roman[str[i]] < roman[str[i + 1]])
                total -= roman[str[i]];
            else
                total += roman[str[i]];
        }

        return total + roman[lastChar];
    }

}