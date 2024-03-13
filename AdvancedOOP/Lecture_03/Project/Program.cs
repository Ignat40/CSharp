using System.Diagnostics;
using System.Transactions;
using DemoLibrary.Modles;

namespace DemoLibrary
{
    public class Program
    {
        public static void Main()
        {
            bool flag = false;

            while (!flag)
            {
                Console.Clear();
                Console.WriteLine("Welcome to a custom console application");
                Console.WriteLine("Enter one of the following: ");
                Console.WriteLine("1. Calculator ");
                Console.WriteLine("2. Person Adding Program ");
                Console.WriteLine("3. Exit ");
                Console.Write("Your choice: ");
                string? userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.Clear();
                        CalculatorFunction();
                        break;
                    case "2":
                        Console.Clear();
                        PersonFunction();
                        break;
                    case "3":
                        flag = true;
                        break;
                }
            }
        }

        public static void CalculatorFunction()
        {
            Console.WriteLine("Enter value for X:");
            Console.Write("X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for Y:");
            Console.Write("Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Choose Operation: ");
            Console.WriteLine("1. Addition ");
            Console.WriteLine("2. Subtraction ");
            Console.WriteLine("3. Multiplication ");
            Console.WriteLine("4. Divition");
            Console.Write("Your choice: ");
            string? operationChoice = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Your result: ");

            switch (operationChoice)
            {
                case "1":
                    Console.WriteLine(Calculator.Add(x, y));
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine(Calculator.Subtract(x, y));
                    Console.ReadKey();
                    break;
                case "3":
                    Console.WriteLine(Calculator.Multiply(x, y));
                    Console.ReadKey();
                    break;
                case "4":
                    Console.WriteLine(Calculator.Divide(x, y));
                    Console.ReadKey();
                    break;

            }

        }

        public static void PersonFunction()
        {
            PersonModel person = new();


            Console.WriteLine("Choose Operation: ");
            Console.WriteLine("1. Add Person ");
            Console.WriteLine("2. View List ");
            Console.Write("Your choice: ");
            string? operationChoice = Console.ReadLine();

            switch (operationChoice)
            {
                case "1":
                    Console.WriteLine("Enter First Name");
                    Console.Write("First Name: ");
                    string? firstNameInput = Console.ReadLine();
                    person.FirstName = firstNameInput;

                    Console.WriteLine("Enter First Name");
                    Console.Write("Last Name: ");
                    string? LastNameNameInput = Console.ReadLine();
                    person.LastName = LastNameNameInput;

                    DataAccess.AddNewPerson(person);

                    break;
                case "2":
                    DataAccess.GetAllPeople();
                    Console.ReadKey();
                    break;
            }
        }

    }

}