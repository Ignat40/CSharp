using System;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

namespace Kata
{
    class Program
    {
        public static void Main()
        {
            int[] dpulicatesArray = { 3, 4, 4, 3, 6, 3 };
            Console.WriteLine($"{Solve(dpulicatesArray)}");
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



    }
}