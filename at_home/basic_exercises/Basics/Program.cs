using System;
using System.Reflection.Metadata;

namespace Basics
{
    class Program
    {
        public static void Main()
        {
        /*
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
        

        //------------ Ex. 3 ------------\\ - Request two integers from the user (m, n) and print the result of the division and the rest of the division on a new line.

            Console.WriteLine("Enter value for m: ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value for n: ");
            double n = Convert.ToDouble(Console.ReadLine());
            double razlika = m / n;
            double remainder = m % n;
            
            if(remainder > 0)
                Console.WriteLine($"{m} divided by {n} is {razlika} with remainder of: {remainder}");
            else
                Console.WriteLine($"The div is {razlika}");
        
        
        //------------ Ex. 4 ------------\\ - program that calculates the arithmetic measurement of 4 factors entered by the user, one for each line

        Console.WriteLine("Enter four numbers: ");
        double q = Convert.ToDouble(Console.ReadLine());
        double w = Convert.ToDouble(Console.ReadLine());
        double e = Convert.ToDouble(Console.ReadLine());
        double r = Convert.ToDouble(Console.ReadLine());
        double avrg = (q + w + e + r) / 4;
        Console.WriteLine($"The average of your numbers is: {avrg}");
        
        */
        //------------ Ex. 5 ------------\\ - write a simple program that solves the roots of quadratic equation

        Console.WriteLine("Your eqation is in the form of: Ax^2 + Bx + C");
        Console.WriteLine("Enter value for A: ");
        double A = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter value for B: ");
        double B = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter value for C: ");
        double C = Convert.ToDouble(Console.ReadLine());

        double D = Math.Sqrt(B*B - 4 * A * C);
        double X1 = (-B + D)/2*A;
        double X2 = (-B - D)/2*A;

        Console.WriteLine($"Root 1: {X1}");
        Console.WriteLine($"Root 2: {X2}");


        }
    }
}
