using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Security.AccessControl;

namespace Training
{
    class Program
    {
        static void Main()
        {
            //--------------------- Ex. 1 --------------------- \\
            /*
                    Console.WriteLine("Enter value for X:");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter value for Y:");
                    int y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter value for Z:");
                    int z = Convert.ToInt32(Console.ReadLine());

                    if(x > y && x > z)
                        Console.WriteLine($"The biggest number is: {x}");
                    else if(y > x && y > z)
                        Console.WriteLine($"The biggest number is: {y}");
                    else
                        Console.WriteLine($"The biggest number is: {z}");


                    //--------------------- Ex. 2 --------------------- \\

                    string accessKey = "password";
                    Console.WriteLine("Enter password: ");
                    string password = Console.ReadLine();
                    bool pass = password == accessKey ? true:false;
                    Console.WriteLine($"Password is: {pass}");

                    //--------------------- Ex. 3 --------------------- \\

                    Console.WriteLine("Enter a letter: ");
                    string letter = Console.ReadLine();
                    if(letter == "a" || letter == "e" || letter == "o"
                    || letter == "u" || letter == "i")
                        Console.WriteLine($"{letter} is vowel!");
                    else    
                        Console.WriteLine($"{letter} is consonant.");

                    //--------------------- Ex. 4 --------------------- \\


                    Console.WriteLine("Enter the first number: ");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the operation: ");
                    string symbol = Console.ReadLine();
                    Console.WriteLine("Enter the seocnd number: ");
                    int number2 = Convert.ToInt32(Console.ReadLine());

                    if(symbol == "+")
                        Console.WriteLine($"{number1} {symbol} {number2} = {number1 + number2}");
                    else if(symbol == "-")
                        Console.WriteLine($"{number1} {symbol} {number2} = {number1 - number2}");
                    else if(symbol == "*")
                        Console.WriteLine($"{number1} {symbol} {number2} = {number1 * number2}");
                    else if(symbol == "/")
                        Console.WriteLine($"{number1} {symbol} {number2} = {number1 / number2}");

                    //--------------------- Ex. 4 --------------------- \\

                    Console.WriteLine("Enter your weight in kgs: ");
                    double weight = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter your height in cm: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    double bmi = weight / (height * height);

                    if(bmi < 18.5)
                        Console.WriteLine($"Your BMI is: {bmi} - UNDERWEIGHT");
                    else if(bmi >= 18.5 && bmi < 25)
                        Console.WriteLine($"Your BMI is: {bmi} - NORMAL WEIGHT");
                    else if(bmi >= 25 && bmi < 30 )
                        Console.WriteLine($"Your BMI is: {bmi} - OVER WEIGHT");
                    else
                        Console.WriteLine($"Your BMI is: {bmi} - OBESE");

            */        //--------------------- Ex. 4 --------------------- \\

            Random generatedNum = new Random();
            int numToGuess = generatedNum.Next(1,101);
            bool isGuessed = false;
            int guessing = 0;
            Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess it?");

            while(!isGuessed)
            {
                Console.WriteLine("Guess: ");
                string guess = Console.ReadLine();
                if(!int.TryParse(guess, out guessing))
                {
                    Console.WriteLine("Enter an integer: ");
                    continue;
                }
                if(guessing < numToGuess)
                {
                    Console.WriteLine("Go bigger");
                }
                else if(guessing > numToGuess)
                {
                    Console.WriteLine("Go lower");
                }
                else 
                {
                    isGuessed = true;
                    Console.WriteLine("Correct!");
                }
            }


        }
    }
}