using System;
using System.Reflection.Metadata;

namespace Basics
{
    class Program
    {
        public static void Main()
        {
        //------------ Ex. 1 ------------\\ - Three numbers are give. Print the sum of the first two and multiply them by the last one.
        
            int x = 5, y = 10, z = 2;

            int sumFirstTwo = x + y;
            int finalResult = sumFirstTwo * z; 

            Console.WriteLine($"The sum of the first two is {sumFirstTwo} and the final result is {finalResult}");

        //------------ Ex. 2 ------------\\ - Let the user input two numbers and list all the elementary mathematical operations.

            Console.WriteLine("Enter two numbers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = a + b;
            int sub = a - b;
            int mul = a * b;
            double div = a / b;
            
            Console.WriteLine($"Sum is: {sum}");
            Console.WriteLine($"Sub is: {sub}");
            Console.WriteLine($"Mul is: {mul}");
            Console.WriteLine($"Div is: {div}");


         //------------ Ex. 2 ------------\\ - Given a number, write a program that returns its cube.

            Console.WriteLine("Enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            double power = 3;
            double res = Math.Pow(number, power);
            Console.WriteLine($"{number} cubed is -> {res}");

        }
    }
}
