using System.Reflection.Metadata;
using System.Runtime.InteropServices.Marshalling;

namespace Lecture_4
{
    class Program
    {

        /// <summary>
        /// Logical Operators - ||-OR  &&-AND  !-is not
        /// 
        /// </summary>
        public static void Main()       
        {
           /* 
            // Write a program to see if two variables are even
            int num = 0; 
            bool convertedConrrectly = false;
            while(!convertedConrrectly)
            {
                Console.WriteLine("Enter a number: ");
                convertedConrrectly = int.TryParse(Console.ReadLine(), out num);
                if(!convertedConrrectly)
                {
                    Console.WriteLine("Not converted...");
                }

            }

            bool isEven = num % 2 == 0; 
            if(isEven)
                Console.WriteLine($"{num} is even!");
            else
            Console.WriteLine($"{num} is not even...");
           


            // for(int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine($"{i+1}");
            // }

            // while(true)
            // { 

            // }

            int number = 0;
            int f = 1; 
            Console.WriteLine("Enter integer to produce the fact of: ");
            number = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= number; i++)
            {
                f *= i;
            }

            Console.WriteLine($"The factorial of {number} is {f}");

            //Using while loop 

            uint n = 0; 
            uint fact = 1;
            bool correctlyConverted = false; 

            while(!correctlyConverted)
            {
                Console.WriteLine("Enter integer to produce the fact of: ");
                correctlyConverted = int.TryParse(Console.ReadLine(), out n);
                if(!correctlyConverted)
                {
                    Console.WriteLine("Insert a valid integer...");
                }
            } 

            for(int i =1; i <=100; i++)
            {

                if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }

                if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine($"{i}");
                }

            }    
                */
                string p = "";
                bool isNull = false;

                while(isNull)
                {
                    Console.WriteLine("Enter a string to see if its polidnrome: ");
                    p = Console.ReadLine();
                    if(p == null)
                        isNull = false;

                }

                string nP = "";

                for(int i = p.Length -1; i >= 0; i--)
                {
                    nP += p[i];
                }
                if(p == nP)
                    Console.WriteLine($"{p} is polindrome.");
                else
                    Console.WriteLine($"{p} is not a polindrome.");


        }
    }
}