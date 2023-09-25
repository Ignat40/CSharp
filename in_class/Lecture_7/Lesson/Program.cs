using System;
using System.Net;
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

        enum Genre
        {
            Fiction,
            NonFiction,
            Mystery,
            Fantasy,
            ScienceFiction,
            Biography,
            Horror,
        }
        struct Author
        {
            public string? FirstName;
            public string? LastName;

        }

        enum WeatherConditions
        {
            sunny,
            cloudy,
            rainy,
            snowy,
            windy,
        }
        struct WeatherReport
        {
            public WeatherConditions Condition;
            public float  Temperature;
            public float WindSpeed; 
            public string? Date;
        }
        public static void Main()
        {
            //FirstHour();
            //SecondHour();
            //BookHolder();

            WeatherReport[] reports = new WeatherReport[]
            {
                new WeatherReport {
                    Condition = WeatherConditions.sunny,
                    Temperature = 25.5f,
                    WindSpeed = 5.0f,
                    Date = "2023-09-20"
                    },
                new WeatherReport{
                    Condition = WeatherConditions.rainy,
                    Temperature = 15.3f,
                    WindSpeed = 10.2f,
                    Date = "2023-09-21" 
                    },
                new WeatherReport{
                    Condition = WeatherConditions.cloudy,
                    Temperature = 18.6f,
                    WindSpeed = 7.3f,
                    Date = "2023-09-22" 
                    }

            };

            while(true)
            {
                Console.WriteLine("Wheater Station");
                Console.WriteLine("1. View Reports \n2. Add a Report \n3. Search by condition \n4. Exit");

                string? choice = Console.ReadLine();
                if(choice == "1")
                {
                    for(int i = 0; i < reports.Length; i++)
                    {
                        Console.WriteLine($"Date: {reports[i].Date} \n Conditions: {reports[i].Condition} \n Temp: {reports[i].Temperature} \n WindSpeed: {reports[i].WindSpeed}");
                        
                    }
                }
                else if(choice == "2")
                {
                    Console.WriteLine("Enter Date (YYYY-MM-DD): ");
                    string? date = Console.ReadLine();
                    
                    Console.WriteLine("Enter weather condition");
                    Console.WriteLine($"0. Sunny");
                    Console.WriteLine($"1. Cloudy");
                    Console.WriteLine($"2. Rainy");
                    Console.WriteLine($"3. Snowny");
                    Console.WriteLine($"4. Windy");
                    int conditionInt;
                    while(!int.TryParse(Console.ReadLine(), out conditionInt))
                    {   
                        Console.WriteLine("Invalid input. Please Try Again.");
                    }
                
                    WeatherConditions conditions = (WeatherConditions)conditionInt;

                    Console.WriteLine("Enter Temp: ");
                    float temperature = 0;
                    while(!float.TryParse(Console.ReadLine(), out temperature))
                    {   
                        Console.WriteLine("Invalid input. Please Try Again.");
                    }

                    Console.WriteLine("Enter Wind speed: ");
                    float windSpeed = 0;
                    while(!float.TryParse(Console.ReadLine(), out windSpeed))
                    {   
                        Console.WriteLine("Invalid input. Please Try Again.");
                    }
                    
                    Array.Resize(ref reports, reports.Length + 1);
                    reports[^1] = new WeatherReport{
                        Condition = conditions,
                        Temperature = temperature,
                        WindSpeed = windSpeed,
                        Date = date.ToUpper()
                    };
                    

                }
                else if(choice == "3")
                {
                    Console.WriteLine("Search by condition: ");
                    Console.WriteLine($"0. Sunny");
                    Console.WriteLine($"1. Cloudy");
                    Console.WriteLine($"2. Rainy");
                    Console.WriteLine($"3. Snowny");
                    Console.WriteLine($"4. Windy");
                    int WeatherConditions = 0;
                    while(!int.TryParse(Console.ReadLine(),out WeatherConditions))
                    {
                        Console.WriteLine("Invalid input. Please Try Again.");
                    }

                    WeatherConditions conditionToSearch = (WeatherConditions)WeatherConditions;
                    for(int i = 0; i < reports.Length; i++)
                    {
                        if(conditionToSearch == reports[i].Condition)
                        {
                            Console.WriteLine($"Date: {reports[i].Date} \n Conditions: {reports[i].Condition} \n Temp: {reports[i].Temperature} \n WindSpeed: {reports[i].WindSpeed}");
                        }
                    }

                }
                else if(choice == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice. Please try again\n");
                }
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

        public static void SecondHour()
        {
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

        public static void BookHolder()
        {
            string? bookTitle = "Initial Title";
            Author bookAuthor;
            bookAuthor.FirstName = "Initial Firstname";
            bookAuthor.LastName = "Initial Lastname";
            
            Genre bookGenre = Genre.Fiction;

            bool exit = false;
            while(!exit)
            {
                Console.WriteLine("1: Update Book \n2: Display Book \n3: Exit");
                string? choice = Console.ReadLine();

                if(choice == "1")
                {
                    Console.WriteLine("Enter a new title: ");
                    bookTitle = Console.ReadLine();

                    Console.WriteLine("Enter the author's first name: ");
                    bookAuthor.FirstName = Console.ReadLine();
                    
                    Console.WriteLine("Enter the author's last name: ");
                    bookAuthor.LastName = Console.ReadLine();

                    Console.WriteLine("Enter the genre (0-6): ");
                    Console.WriteLine("0. Fiction \n1. Nonficiton \n2.Mystery \n3.Fantasy \n4.ScieneFicdtion \n5.Biography \n6. Horror ");

                    Genre genre; 
                    while(!Enum.TryParse(Console.ReadLine(), out genre) ||
                     !Enum.IsDefined(typeof(Genre), genre))
                    {
                        Console.WriteLine("Invalid input. Enter a valig genre 0-6: ");
                    }
                    bookGenre = genre;
                } 
                else if(choice == "2")
                {
                    Console.WriteLine($"Current book details: '\nTItle:{bookTitle} \nAuthor First Name{bookAuthor.FirstName} \nAuthor Last Name{bookAuthor.LastName} \nGenre: {bookGenre}");
                }
                else if(choice == "3") 
                    exit = true;
                else
                {
                    Console.WriteLine("Invalid choice. Try again: ");
                }
                    
            }
        }

    }
}