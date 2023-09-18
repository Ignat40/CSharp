using System;
using System.Runtime.InteropServices;

namespace Practise
{
    class Program
    {
        static void Main()
        {
//----------------- Ex. 1 - Password Validation -----------------\\
/*
        string pass = "password"; 
        bool isCorrect = false;

        while(!isCorrect)
        {
            Console.WriteLine("Enter your password:");
            string passToEnter = Console.ReadLine();

            if(passToEnter != pass)
            {
                Console.WriteLine("Wrong password. Try again: ");
                continue;
            }
            else
            {
                Console.WriteLine("Correct!");
                isCorrect = true;
            }
        }

//----------------- Ex. 2 - While Factorial -----------------\\
      
        int number;
        int initial = 1;
        int f = 1;
        Console.WriteLine("Enter number:");
        number = Convert.ToInt32(Console.ReadLine());

        while(initial <= number)
        {
            f *= initial;
            initial++;
        }
        Console.WriteLine($"The factorial of {number} is {f}");

//----------------- Ex. 3 - Multiplicaiton Table -----------------\\
*/
        int multNum;
        int table = 1; 
        Console.WriteLine("Number: ");
        multNum = Convert.ToInt32(Console.ReadLine());

        while(table <= 10)
        {
            Console.WriteLine($"{table} * {table} = {multNum*table}");
            table++;
        }

        }
    }
}