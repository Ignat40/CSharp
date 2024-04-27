using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace LeetCode;

public class Solution28
{
    public static int StrStr(string haystack, string needle)
    {
        // Initialize the LPS array with the same length as the pattern
        int[] lps = new int[needle.Length];

        // Setting the first element to 0
        lps[0] = 0;

        // variables for comparison 
        int i = 1;
        int prevLps = 0;

        while (i < needle.Length)
        {
            if (needle[i] == needle[prevLps])
            {
                prevLps++;
                lps[i] = prevLps;
                i++;
            }
            else
            {
                if (prevLps != 0)
                    // If characters don't match and prevLps is not at the beginning
                    // Update prevLps to the previous value from LPS array
                    prevLps = lps[prevLps - 1];
                else
                {
                    // If prevLps is at the beginning, no match found, set LPS value to 0
                    lps[i] = 0;
                    i++;
                }

            }

        }

        i = 0;
        int j = 0;

        while (i < haystack.Length)
        {
            if (haystack[i] == needle[j])
            {
                i++;
                j++;
            }
            else
            {
                if (j == 0)
                    i++;
                else
                    j = lps[j - 1];
            }

            if(j == needle.Length)
                return i - needle.Length;
        }
        
        return -1;

    }
}