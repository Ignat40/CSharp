using System.Diagnostics.Metrics;

namespace Kata
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(MakeAWindow(6));
            // ---------
            // |...|...|
            // |...|...|
            // |...|...|
            // |---+---|
            // |...|...|
            // |...|...|
            // |...|...|
            // ---------

        }

        public static string MakeAWindow(int num)
        {
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", num * 2 + 3)));

            for (int i = 0; i < 3; i++)
            {
                while (i < num)
                {
                    Console.Write("|" + string.Concat(Enumerable.Repeat(".", num)));
                    Console.WriteLine("|" + string.Concat(Enumerable.Repeat(".", num)) + "|");
                    i++;
                }

            }

            Console.WriteLine("|" + string.Concat(Enumerable.Repeat("-", num)) + "+" + string.Concat(Enumerable.Repeat("-", num)) + "|");

            for (int i = 0; i < 3; i++)
            {
                while (i < num)
                {
                    Console.Write("|" + string.Concat(Enumerable.Repeat(".", num)));
                    Console.WriteLine("|" + string.Concat(Enumerable.Repeat(".", num)) + "|");
                    i++;
                }

            }
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", num * 2 + 3)));

            return string.Empty;
        }
    }
}