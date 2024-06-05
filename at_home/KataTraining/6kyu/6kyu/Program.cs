using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.CompilerServices;


namespace Kata
{
    public class Program
    {
        public static void Main()
        {
            // int[] nubmers = { 1, 2, 3, 1, 2, 1, 2, 3 };
            int[] nubmers = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(DeleteNthElem(nubmers, 2));

            // Expected -> [1, 2, 3, 1, 2, 3]
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

        public static int[] DeleteNthElem(int[] arr, int x)
        {
            int counter = 0;
            bool flag = false;
            int[] noDup = Array.Empty<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        flag = true;

                    if (counter == x)
                        noDup.Append(arr[i]);
                }
            }

            if(flag)
                Console.WriteLine("Found!");
            else
                Console.WriteLine("Not Found!");

            foreach (var bajo in noDup)
            {
                Console.WriteLine(bajo);
            }

            return noDup;
        }
    }
}

