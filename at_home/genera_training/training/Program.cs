using System;
using System.Data;
using System.Diagnostics.Contracts;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Xml.Schema;

namespace Practice
{
    class Program
    {
        public static void Main()
        {
            CombineDigits();
        }

        public static void guessTheNumber()
        {
        //------------------------- Ex. 1 -------------------------\\

            Random random = new Random();
            int toGuess = random.Next(1,101);
            int myGuess; 
            bool isGuessed = false; 

            Console.WriteLine("Let's play a game!");
            Console.WriteLine("Guess my number between 1 - 100! ");

            while(true)
            {
                Console.WriteLine($"Your guess: " );
                
                if(!int.TryParse(Console.ReadLine(), out myGuess))
                {
                    Console.WriteLine("Invalid input! Please enter integer: ");
                    continue;
                }
                
                if(myGuess < toGuess)
                {
                    Console.WriteLine("Try bigger \n");
                    continue;
                }

                if(myGuess > toGuess)
                {
                    Console.WriteLine("Try lower \n");
                    continue;
                }
                else
                {
                    Console.WriteLine($"You Win! My number was {toGuess}");
                    isGuessed = true;
                }

                if(isGuessed)
                    break;

            }

        }

        public static void CombineDigits()
        {
        //------------------------- Ex. 2 -------------------------\\

        int temp = 0;
        int sum = 0;

        Console.WriteLine("This program will sum the digits of the number you enter!");

        while(true)
        {
            Console.WriteLine("Enter your number: ");

            if(int.TryParse(Console.ReadLine(), out int number) && number > 0)
            {
                while(number > 0)
                {
                    temp = number % 10;
                    sum += temp;
                    number /= 10;
                }
                Console.WriteLine($"Sum: {sum}");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Try again! \n");
                continue;
            }
        }
        


        }

    }
}