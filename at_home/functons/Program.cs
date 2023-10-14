using System;
using System.Data;
using System.Diagnostics.Metrics;
using System.Net.Http.Headers;
using System.Security.Cryptography;

namespace Functions
{

    class Program
    {
        public static void Main()
        {
           //PrintNumber();

            //Ex. 2
            /*
            Console.WriteLine("Enter a sentance: ");
            string? input = Console.ReadLine();
            int count = WordCounter(input);
            Console.WriteLine(count);
            

            //Ex. 3
            Console.WriteLine("Enter value for number 1:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value for number 2:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter operation:");
            string operatioin = Console.ReadLine();
            double result = Calculator(num1, num2, operatioin);
            Console.WriteLine($"\n Result: {num1} {operatioin} {num2} = {result}");


            //Ex. 4
            Console.WriteLine("Enter string to reverse: ");
            string? userInput = Console.ReadLine();
            Console.WriteLine($"Your string is palindrome: {IsPalindrome(userInput)}");
*/

            //Ex. 5
            Console.WriteLine("Enter number to check its factorial: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The factorial of {n} is {Factorial(n)}");


        }
        public static void PrintNumber() //FUnctoin that creates a random number
        {
    //--------------------- Ex.1 ---------------------\\

            Random number = new();
            int num = number.Next(1, 11);
            Console.WriteLine($"Your rndm number is: {num}");
        }
        public static int WordCounter(string? input)
        {

            int wordCounter = input.Split(' ').Length;
            return wordCounter;
        }

        public static double Calculator(double num1, double num2, string sign)
        {
    //--------------------- Ex.3 ---------------------\\

            if(sign == "+")
                return num1 + num2;
            else if(sign == "-")
                return num1 - num2;
            else if(sign == "*")
                return num1 * num2;
            else if(sign == "/")
                return num1 / num2;
            else
                Console.WriteLine("Invalid operatioin");
                return 0; 
        }

        public static bool IsPalindrome(string? input)
        {
            string cleanInput = input.Replace(" ", "").ToLower();
            char[] reversedString = cleanInput.ToCharArray();

            for(int i = 0; i < cleanInput.Length / 2; i++)
            {
                if(cleanInput[i] != cleanInput[cleanInput.Length - i - 1])
                    return false;
            }

            return true;
        }

        public static int Factorial(int number)
        {
            int f = 1;

            for (int i = 1; i <= number; i++)
            {
                f *= i;
            }

            return f;
        }

    
    
    }
}