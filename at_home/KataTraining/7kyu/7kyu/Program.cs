using System;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Timers;
using System.Collections.Generic;


namespace Kata
{
    class Program
    {
        public static void Main()
        {

            Console.WriteLine(PrinterError("aaabbbbha.ljvhapsjdnav;nvadijjjm"));

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

        public static long[] EqSumPowDig(long hmax, int exp)
        {

            List<long> listOfNumbers = new List<long>();
            for (int i = 10; i <= hmax; i++)
            {
                string digits = i.ToString();
                int sum = 0;
                foreach (var d in digits)
                {
                    int digit = int.Parse(d.ToString());
                    int poweredDigits = (int)Math.Pow(digit, exp);
                    sum += poweredDigits;


                }

                if (sum == i)
                {
                    listOfNumbers.Add(i);
                }
            }

            foreach (var d in listOfNumbers)
            {
                Console.WriteLine(d);
            }

            return listOfNumbers.ToArray();
        }


        public static int TestFunciton(int n)
        {
            int divisorCount = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    divisorCount++;
            }

            int[] divisors = new int[divisorCount];
            int iterator = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    divisors[iterator] = i;
                    iterator++;
                }
            }

            foreach (var d in divisors)
            {
                Console.WriteLine(d);
            }

            Console.WriteLine($"Total divisors: {divisors.Length}");
            return divisors.Length;

        }

        public static string PrinterError(String s)
        {
            int erros = 0;
            string chars = "abcdefghijklm";

            for(int i = 0; i < s.Length; i++)
            {
                if(!chars.Contains(s[i]))
                {
                    erros++; 
                }
            }

            string errorCount = $"{erros} / {s.Length}";
            return errorCount;
        }

    }
}

