using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;


namespace Kata
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(FindMinNum(70));

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

        public static int FindMinNum(int n)
        {
            int numToFind = 1;
            
            while (true)
            {
                int divisors = 0;
                for (int i = 1; i <= numToFind; i++)
                {
                    if (numToFind % i == 0)
                    {
                        divisors++;
                    }

                }

                if (divisors == n)
                    break;
                else    
                    numToFind++;
            

            }

            return numToFind;
        }
    }
}