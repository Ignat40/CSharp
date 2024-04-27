namespace LeetCode
{
    public class Program
    {
        public static void Main()
        {

            string haystack = "AAAXAAAAX";
            string needle = "AAAA";
            int lps = Solution28.StrStr(haystack, needle);

            Console.WriteLine("index: " + lps);
            

        }
    }
}