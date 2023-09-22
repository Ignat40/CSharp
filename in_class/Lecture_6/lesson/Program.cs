using System;
using System.Data;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace Review
{
    class Problem
    {
        public static void Main()
        {
            ElevatorSimulator();
        }

        /// <summary>
        /// Program / Function: Elevator Simulator
        /// This program simulates basic operation of an elevtor.
        /// Features include selectoin floors and managing the number of passengers.
        /// The elevator can only hold & passengers. 
        /// There are 10 floors. 
        /// 
        /// Functions: 
        /// Go Up
        /// Go Down
        /// Select level to enter the elevaotr
        /// Select level to exit the elevator
        /// Make sure there are no more than 8 passanger
        /// </summery>
        /// 

        public static void ElevatorSimulator()
        {
            int cerrentFloor = 0;
            int destinationFloor;
            int maxPassengers = 5;
            int currentPassengers = 0; 
            int maxFloors = 10; 

            while(true)
            {
                Console.WriteLine($"Current floor: {cerrentFloor}");
                Console.WriteLine($"Current passengers: {currentPassengers}/{maxPassengers}");
                Console.WriteLine($"Enter what floor you want to go to: 0-10 or -1 if you want to exit");

                if(!int.TryParse(Console.ReadLine(), out destinationFloor))
                {
                    Console.WriteLine("Invalid input... Please enter an integer: ");
                    continue;
                }

                if(destinationFloor == -1)
                {
                    Console.WriteLine($"Exiting the elevator.");
                    break;
                }

                if(destinationFloor < 0 || destinationFloor > 10)
                {
                    Console.WriteLine("Invlaid floor. Enter a number between 1 - 10");
                    continue;
                }

                if(cerrentFloor == destinationFloor)
                {
                    Console.WriteLine("You are already on the desired floor");
                }

                while(cerrentFloor != destinationFloor)
                {
                    Console.WriteLine("Moving...");

                    if(cerrentFloor < destinationFloor)
                        cerrentFloor++;
                    else
                        cerrentFloor--; 
                    
                }

                Console.WriteLine($"Arrived to {cerrentFloor}th floor");


                Console.WriteLine("Enter the number of the netering passengers: ");
                if(!int.TryParse(Console.ReadLine(), out int enteringPassengers))
                {
                    Console.WriteLine("Invalid input, assuming zero");
                    enteringPassengers = 0;
                }

                if(!int.TryParse(Console.ReadLine(), out int exitingPassengers))
                {
                    Console.WriteLine("Invalid input, assuming zero");
                    exitingPassengers = 0;
                }

                currentPassengers += enteringPassengers - exitingPassengers; 

                if(currentPassengers > maxPassengers)
                {
                    Console.WriteLine("TOO MANY PEOPLE!!! Reduce the amount of passsengers!");
                    Console.WriteLine("Enter  the amount of passgengers exitting: ");

                    int passangerToExit;

                    while(true)
                    {
                        if(!int.TryParse(Console.ReadLine(), out passangerToExit))
                        {
                            Console.WriteLine("Invalid input");
                            continue;
                        }

                        if(currentPassengers - passangerToExit >= 0 && currentPassengers - passangerToExit <= maxPassengers)
                        {
                            currentPassengers -= passangerToExit;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("sdfasd");
                        }
                    }
                }




            }

        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static void AvgGrade()
        {

            bool corrcetInput = false;
            double sum = 0;

            Console.WriteLine("How many grades do you want to input: ");
            while (!corrcetInput)
            {
                string? numberOfGradesString = Console.ReadLine();
                if (int.TryParse(numberOfGradesString, out int numberOfGrades))
                {
                    Console.WriteLine("I could not convert the input into a number, Please enter again: ");
                    continue;
                }

                corrcetInput = true;
                //Loop through the number of grades the users asked for
                for (int i = 0; i < numberOfGrades; i++)
                {
                    Console.WriteLine("Enter grade: ");
                    //Stores the user input from the console. 
                    string? gradeString = Console.ReadLine();
                    if (double.TryParse(gradeString, out double gradeInput))
                    {
                        sum += gradeInput;
                    }
                    else
                    {
                        Console.WriteLine("Not a valid input...");
                        i--;
                    }
                }

                double averageGrade = sum / numberOfGrades;
                Console.WriteLine($"The average of {numberOfGrades} is: {averageGrade}");

            }

            /*
             Console.WriteLine("Enter a number: ");

              string? grade = Console.ReadLine();
             //First way -> Convert a string grade into a float
             double avg = Convert.ToDouble(grade);

             //Secodn way -> Try Parse \/

             if(double.TryParse(grade, out double avg2))
             {
                 Console.WriteLine("YES");
                 Console.WriteLine($"Average is {avg2}");
             }
             else
             {
                 Console.WriteLine("NO");
                 Console.WriteLine($"Your grade: {grade}");
             }

             Console.WriteLine($"The grade is: {grade}");
             */
        }

        public static void Junk()
        {
            // Variables and expressions 
            // An expressoin takes two or more vars 
            // and does some math to result in one value 
            // x + y 

            // A statement is a full line of code that takes an expression and either runs more code or assigns 
            // int z = y + x 

            int x = 5; //statement
            int y = 10;
            int z = x + y;
            Console.WriteLine($"{z} before Multiply");
            z = Multiply(x, y);
            Console.WriteLine($"{z} after Multiply");

            string str = "bob"; //immutable (read-only); cannot be changed 
            str = "bob" + " is cool";
            Console.WriteLine(str);

            //FLOW CONTROLS 
            // boolean logic; branching(if statements); looping(do while, while, for)

            bool isEven = false;
            if (z % 2 == 0)
                isEven = true;

            if (isEven)
                Console.WriteLine($"{z} is even!");
            else
                Console.WriteLine($"{z} not is even!");


            isEven = z % 2 == 0 ? isEven = true : isEven = false;
            Console.WriteLine(isEven);


        }

    }
}

