using System;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Kata
{
    class Program
    {
        public static void Main()
        {
            System.Console.WriteLine($"{NextSquare(121)}");
            System.Console.WriteLine($"{NextSquare(625)}");
            System.Console.WriteLine($"{NextSquare(-114)}");
            System.Console.WriteLine($"{NextSquare(15241383936)}");
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


    }
}