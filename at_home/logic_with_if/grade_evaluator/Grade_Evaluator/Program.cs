using System;

namespace Equation
{

    class Program
    {
        static void Main()
        {
            ///<summary>
            ///Problem: 
            ///Create a C# program
            ///that calculates a student's 
            ///grade from an integer. 
            ///Ask the user for a number (x) 
            ///and answer the following:
            ///10 - A+
            ///9 - A
            ///7,8 - B
            ///6 - C
            ///5 - E
            ///0,4 - F
            ///Use the switch, break and default instruction of C#. 


            Console.WriteLine("Please enter a integer between 1 and 10: ");
            int selectedOption = Convert.ToInt32(Console.ReadLine());

    
            switch (selectedOption)
            {

                case 10:
                    Console.WriteLine("A+");
                    break;

                case 9:
                    Console.WriteLine("A+");
                    break;

                case 8:
                case 7:
                    Console.WriteLine("B");
                    break;

                case 6:
                    Console.WriteLine("C");
                    break;

                case 5:
                    Console.WriteLine("E");
                    break;
                
                case 4:
                case 3: 
                case 2:
                case 1: 
                case 0:
                    Console.WriteLine("F");
                    break;

                default:
                    Console.WriteLine("Invalid input...");
                    break;
            }




        }
    }

}