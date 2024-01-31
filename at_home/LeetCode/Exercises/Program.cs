namespace LeetCode
{
    public class Program
    {
        public static void Main()
        {
            ValidParentheses validParentheses = new();
            Console.WriteLine(validParentheses.IsValid("(]"));
        }
    }
}