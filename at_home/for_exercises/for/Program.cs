using System;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;

namespace ForLoops
{
    class Program
    {
        static void Main()
        {
//----------------- Ex. 1 - Counting Up and Down -----------------\\

        Console.Write("Ascending:");
        for(int i = 1; i <= 10; i++)
        {
            Console.Write($"{i}, ");
        }
        Console.Write("Descending:");
        for(int i = 10; i >= 1; i--)
        {
            Console.Write($"{i}, ");
        }

        Console.WriteLine();
//----------------- Ex. 2 - Write the even numbers between 1-20 -----------------\\

        int sum = 0;
        for(int i = 1; i < 20; i++)
        {
            if(i % 2 != 0) continue;
            sum += i;
        }
        Console.WriteLine($"The sum is: {sum}");


//----------------- Ex. 3 - Count Characters in a String -----------------\\
        
        //INITIALIZING THE .LENGTH FUNCTION!

        Console.WriteLine("Enter string: ");
        string word = Console.ReadLine();
        int counter = 0;

        for(int i = 1; i < word.Length; i++)
        {
            counter++;
        }
        Console.WriteLine($"{word} consists of {counter} letters");

//----------------- Ex. 4 - Print a pattern -----------------\\

        Console.WriteLine("Enter limit for the start: ");
        int limit = Convert.ToInt32(Console.ReadLine());

        for(int i = 1; i <= limit; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }


//----------------- Ex. 5 - FOR Factorial -----------------\\

        Console.WriteLine("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int f = 1;
        
        for(int i = 1; i <= number; i++)
        {
            f *= i;
        }
        Console.WriteLine($"The factorial of {number} is {f}");

        }
    }
}