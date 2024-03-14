using System.Net.Http.Headers;

namespace SOLID
{
    // SRP states that class should only have ONE responsibility
    // or only have one reason to change 
    public class SRP //Single Responsibility Principle
    {
        // public static void Main() // This is a bad example as we are changing the Program.cs file multiple times!
        // {
        //     Console.WriteLine("Welcome to my application!");

        //     Person user = new Person();

        //     Console.WriteLine("What is your first name: ");
        //     user.FirstName = Console.ReadLine();

        //     Console.WriteLine("What is your last  name: ");
        //     user.LastName = Console.ReadLine();

        //     if(string.IsNullOrEmpty(user.FirstName))
        //     {
        //         Console.WriteLine("You did not enter a valid first name!");
        //         Console.ReadLine();
        //         return;
        //     }

        //     if(string.IsNullOrEmpty(user.LastName))
        //     {
        //         Console.WriteLine("You did not enter a valid last name!");
        //         Console.ReadLine();
        //         return;
        //     }

        //     Console.WriteLine($"Your user name is: {user.FirstName.Substring(0,1)}{user.LastName}");
        //     Console.ReadLine();
        // }

        // Below is what is a good idea to be done!

        public static void Main()
        {
            StandartMessages.SayWelcomeMessage();

            Person user = PersonDataCapture.Capture();

            bool isUserValid = PersonValidator.Validate(user);
            if(isUserValid == false)
            {
                StandartMessages.EndApplication();
                return;
            }
            
            AccountGenerator.CreateAccount(user);
            StandartMessages.EndApplication();
            
        }
    }
}