using System;
using System.Diagnostics.Metrics;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Timers;

namespace Kata
{
    class Program
    {
        public static void Main()
        {
            string? word = "This is an example!";
            string? word2 = "sihT si na !elpmaxe";

            Console.WriteLine($"Reversed -> {ReverseString(word)}");
            Console.WriteLine($"Reversed -> {ReverseString(word2)}");

        }

        public static string DateNbDays(double a0, double a, double p)
        {
            p = p / 36000;

            double numberOfDays = Math.Ceiling(Math.Log(a / a0) / (Math.Log(1 + p)));
            DateTime startDay = new DateTime(2016, 1, 1);
            DateTime targetDate = startDay.AddDays(numberOfDays);
            string formattedDate = targetDate.ToString("yyyy-MM-dd");
            return formattedDate + " Days: " + numberOfDays;

        }

        public static int[] Solve(int[] arr)
        {
            int[] cleanArray = new int[arr.Length];
            int count = 0;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                bool isDuplicate = false;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    cleanArray[count] = arr[i];
                    count++;
                }
            }

            int[] result = new int[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = cleanArray[count - 1 - i];
            }

            // foreach(var el in result)
            // {
            //     Console.Write(el);
            // }
            return result;
        }

        public static int Getsum(int x, int b)
        {
            //------------------------- Ex. 10 -------------------------\\

            int sum = 0;

            if (x < b)
            {
                for (int i = x; i <= b; i++)
                {
                    sum += i;
                }
            }
            else if (x > b)
            {
                for (int i = b; i <= x; i++)
                {
                    sum += i;
                }
            }
            else
            {
                sum = x;
            }

            return sum;

        }

        public static bool AmIAfraid(string day, int number)
        {
            bool amAfraid = false;
            switch (day)
            {
                case "Moday":
                    if (number == 12)
                        amAfraid = true;
                    else
                        amAfraid = false;
                    break;
                case "Tuesday":
                    if (number > 95)
                        amAfraid = true;
                    else
                        amAfraid = false;
                    break;
                case "Wednesday":
                    if (number == 34)
                        amAfraid = true;
                    else
                        amAfraid = false;
                    break;
                case "Thursday":
                    if (number == 0)
                        amAfraid = true;
                    else
                        amAfraid = false;
                    break;
                case "Friday":
                    if (number % 2 == 0)
                        amAfraid = true;
                    else
                        amAfraid = false;
                    break;
                case "Saturday":
                    if (number == 56)
                        amAfraid = true;
                    else
                        amAfraid = false;
                    break;
                case "Sunday":
                    if (number == 666 || number == -666)
                        amAfraid = true;
                    else
                        amAfraid = false;
                    break;
                default:
                    return false;
            }

            return amAfraid;
        }

        public static long NextSquare(long num)
        {
            long sqrt = (long)Math.Sqrt(num);

            if (sqrt * sqrt == num)
            {
                return (sqrt + 1) * (sqrt + 1);
            }
            else
            {
                return -1;
            }
        }

        public static bool isIsogram(string isogram)
        {
            string v = isogram.ToLower();

            for (int i = 0; i < v.Length; i++)
            {
                for (int j = i + 1; j < v.Length; j++)
                {
                    if (v[i] == v[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static int ElevatorDistance(int[] floors)
        {
            int floorsTravelled = 0;

            for (int i = 0; i < floors.Length - 1; i++)
            {
                int result = 0;

                if (floors[i] > floors[i + 1])
                {
                    result = floors[i] - floors[i + 1];
                }
                else if (floors[i] < floors[i + 1])
                {
                    result = floors[i + 1] - floors[i];
                }

                floorsTravelled += result;
            }

            return floorsTravelled;
        }

        public static string ReverseString(string? str)
        {
            string[] word = str.Split(' ');

            for (int i = 0; i < word.Length; i++)
            {
                char[] charArray = word[i].ToCharArray();
                Array.Reverse(charArray);
                word[i] = new string(charArray);
            }
            return string.Join(" ", word);
        }

    }
}

