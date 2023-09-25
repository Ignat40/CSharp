using System;
using System.Runtime.InteropServices;
using System.Xml;

namespace Lecture
{
    class Program
    {
        enum Days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
        }

        struct Point
        {
            public int X;
            public int Y;

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public double DistanceToOrigin()
            {
                return Math.Sqrt(X*X + Y*Y);
            }
        }

        public static void Main()
        {
            //FirstHour();
            //Multi-dimetional Arrays and Jagged Arrays

            //Multi-dietional Array
            int[,] multiArray = new int[,] {{1,2}, {3,4}};
            //Console.WriteLine($"Multidimensional: First element: {multiArray[0,0]}");

            //Jagged Array
            int[][] jaggedArray = new int[][]
            {
                new int[] {1,2},
                new int[] {3, 4, 5,}
            };

            //Console.WriteLine($"Jagged array first element: {jaggedArray[0][0]}");


            //Implicit and explicit conversion

            float originalFloat = 42.99f;
            int convertedInt = (int)originalFloat;
            float reversedFloat = (float)convertedInt;
            //Console.WriteLine($"Reversed float is {reversedFloat}");

            //Struct example

            Point p = new(3,4);
            double distance = p.DistanceToOrigin();
            //Console.WriteLine($"Distance to origin from {p.X},{p.Y} is: {distance}");

            Days currentDay = Days.Monday;
            if(currentDay == Days.Saturday || currentDay == Days.Sunday)
            {
                Console.WriteLine($"{currentDay} is a weekend");
            }
            else
            {
                Console.WriteLine($"{currentDay} is a weekday.");
            }

        }

        public static void FirstHour()
        {
            //Enum
            Days today = Days.Monday;
            //Console.WriteLine($"Today is: {today}");

            //Implicit and explicit type conversion
            int x = 5;
            long y = 10; 
            float z = 7.5f;
            float num1 = 10.25f;
            float num2 = 25.75f;
            //z = x; 
            y = x; //implicit conversion

            //x = (int)z; //Explicit conversion 

            float num3 = num1 / (float)x;
            float num4 = (int)num1 / x; 

            //Console.WriteLine(num4); 

            //

            Point point = new Point(1, 3);
            Point point2;
            point.X = 2;
            point.Y = 4;

            //Creating and using Array Types

            int[] intArray = new int[] {3, 4, 3, 4, 5, 1};
            int[] intArray2 = new int[5];
            intArray2[0] = 1;
            intArray2[1] = 2;
            intArray2[2] = 3;
            intArray2[3] = 4;
            intArray2[4] = 5;
            const int numElemets = 5;
            int[] intArray3 = new int[numElemets];


            //Console.WriteLine($"First element: {intArray[0]}, Second element: {intArray[^1]}");

            //Manipulating string values

            string str1 = "Hello, ";
            string str2 = "World!";
            str1 = str1.Trim(); // trims all the redundant space 
            string combine = str1 + str2;

            Console.WriteLine(combine);
            string upperCase = combine.ToUpper();
            Console.WriteLine($"To upper: {upperCase}");
        }

    }
}