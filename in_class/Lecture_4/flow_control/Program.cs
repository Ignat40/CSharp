using System.Reflection.Metadata;
using System.Runtime;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Channels;
using System.Threading.Tasks.Dataflow;

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
                
                ///
                /// FINISH THIS THING!
                ///
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

            

            ///<summery>
            ///Problem: Simple ATM                     |
            ///Write a program simulating an ATM that   |
            ///allows deposits, withdrals and  balance  | UNFINISHED 
            ///inquruees.                               |
            ///</summery>                               |

            double balance = 1000; 
            int selectedOption = 0; 

            while(true)
            {
                bool quit = false; 
                double depositAmout = 0;
                double wihtdrawalAmount = 0;

                Console.WriteLine("Welcome to the OOP ATM. Choose one of the following options: ");
                Console.WriteLine("1. Deposit.");
                Console.WriteLine("2. Withdrawal.");
                Console.WriteLine("3. Balance Inquiry.");
                Console.WriteLine("4. Quit.");
                bool correctInput = int.TryParse(Console.ReadLine(), out selectedOption);
                
                if(!correctInput)
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                switch(selectedOption)
                {
                    case 1:
                        Console.WriteLine("How much money would you like to deposite?");
                        correctInput = double.TryParse(Console.ReadLine(), out depositAmout);
                        
                        if(!correctInput || depositAmout < 0)
                        {
                            Console.WriteLine("Sorry, pal, I don't play thay way...");
                            break;
                        }

                        balance += depositAmout; 

                        break;

                    case 2:
                        Console.WriteLine("How much money would you like to withdraw?");
                        correctInput = double.TryParse(Console.ReadLine(), out wihtdrawalAmount);

                        if(!correctInput || wihtdrawalAmount < 0)
                        {
                            Console.WriteLine("Sorry, pal, I don't play thay way...");
                            break;
                        }

                        balance -= wihtdrawalAmount; 

                        break;

                    case 3:
                        Console.WriteLine($"Your balance is {balance.ToString()}");
                        break;
                    case 4:
                        quit = true;
                        break;
                    default
                        break;
                }
                

                if(selectedOption == 4)
                    break; 
            }
            Console.WriteLine("Thank you for using the ATM!")

            

            ///<summery>
            ///Problem: Simple Quiz                     |
            ///That asks theuser questioins using dict  |  
            ///ionraties.                               |
            ///</summery>                               |

            int score = 0; 
            int questionValue = 5;

            Dictionary<string, string> questionsAndAnswers = new()
            {
                {"What is 2 + 2?", "4"},
                {"What is the capital of France?", "Paris"},
                {"Which planet is know to be the RED PLANET?", "Mars"}
            };

            int qeustionCount = questionsAndAnswers.Count;
            int questionsAndAnswered = 0;

            foreach(var questioins in questionsAndAnswers)
            {
                string answer;
                Console.WriteLine(questioins.Key);
                answer = Console.ReadLine();
                answer = answer?.ToLower();
                if(answer == questioins.Value.ToLower())
                {
                    score += questionValue;
                    Console.WriteLine($"Correct! You win {questionValue} points!");
                    Console.WriteLine($"Your score is now: {score}");
                }
                else
                {
                    Console.WriteLine($"Sorry, that answer is wrong!");
                    Console.WriteLine($"The correct answer was: {questioins.Value.ToLower()}");
                }
            }
            */

            ///<summery>
            /// Problelm: Simple Avg Grade Calculator
            /// Create a program that allows the users to
            /// intput his grades for multiple subjects.
            /// The calculate and display the average grade.
            ///</summery>
            
            List<int> grades = new();
            int optionSelected = 0;
            bool exit = false;

            while(true)
            {
                Console.WriteLine("1. Add Grade.");
                Console.WriteLine("2. Calculate Avg Grade.");
                Console.WriteLine("3. Exit");
                bool correctInput = int.TryParse(Console.ReadLine(), out optionSelected);

                if(!correctInput)
                {
                    Console.WriteLine("Invalid input. Please select a number between 1 and 3.");
                    continue;
                }

                switch(optionSelected)
                {
                    case 1:
                        Console.WriteLine("How many grades you want to add? ");
                        
                        if(!)

                    case 2:
                        break;
                    case 3:
                        exit = true;
                        break;
                }
            }



        }
    }
}