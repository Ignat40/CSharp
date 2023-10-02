using System.Diagnostics;
using System.Net;

namespace Bro
{
    class Program
    {

        public enum ProductCodes
        {
            Milk = 0,
            Juice = 1,
            Tea = 2
        }

        enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday

        }

        enum TrafficLight
        {
            Red,
            Yellow,
            Green
        }

        enum Directoins
        {
            Up,
            Down,
            Left,
            Right,
            Out
        }

        enum CardSuits
        {
            Hearts = 10,
            Diamods = 20,
            Clubs = 30,
            Spades = 40
        }
        public static void Main()
        {
            //TypeConvertion();
            //ENums();
            Ex4();
        }

        public static void Ex4()//Declare an enum named CardSuit and assign specific integer values to its values: Hearts (10), Diamonds (20), Clubs (30), and Spades (40). Write a program that takes a numeric input from the user and prints the corresponding card suit. If the input doesn't match any enum value, print "Invalid input".
        {
            bool flag = false;
            CardSuits hearts = CardSuits.Hearts;
            CardSuits diamonds = CardSuits.Diamods;
            CardSuits Clubs = CardSuits.Clubs;
            CardSuits Spades = CardSuits.Spades;

            while(!flag)
            {
                Console.WriteLine("Enter Value To Get Suit: ");
                
                if(int.TryParse(Console.ReadLine(), out int suit))
                {
                    switch(suit)
                    {
                        case 10:
                            Console.WriteLine($"10 -> {hearts}");
                            break;
                        case 20:
                            Console.WriteLine($"10 -> {diamonds}");
                            break;
                        case 30:
                            Console.WriteLine($"10 -> {Clubs}");
                            break;
                        case 40:
                            Console.WriteLine($"10 -> {Spades}");
                            break;
                        case 1:
                            flag = true;
                            break;
                        
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number. Please use \"10\",\"20\",\"30\",\"40\"");
                }

                if(flag)
                    break;
            }
        }

         public static void Ex3()//Create an enum named Direction with values Up, Down, Left, and Right. Write a program that randomly selects a direction and prints a message like "Player moved Up".
        {
            Console.WriteLine("Directions!");
            bool stop = false;

            while(!stop)
            {
                Console.WriteLine("Enter directions: ");
                string userInput = Console.ReadLine();

                if(Enum.TryParse(userInput, out Directoins directoins))
                {
                    switch(directoins)
                    {
                        case Directoins.Up:
                            Console.WriteLine("The player moved UP!");
                            break;
                        case Directoins.Down:
                            Console.WriteLine("The player moved Down!");
                            break;
                        case Directoins.Left:
                            Console.WriteLine("The player moved Left!");
                            break;
                        case Directoins.Right:
                            Console.WriteLine("The player moved Right!");
                            break;
                        case Directoins.Out:
                            stop = true;
                            break;
                    }
                }
                else    
                {
                    Console.WriteLine("Invalid directions. Please use one of the following: \"Up\", \"Down\",\"Left\",\"Right\"");
                }

                if(stop)
                    break;
            }

        }
        
        public static void Ex2()//If the user enters "Red", the program should output "Stop". Use Enums.
        {
            Console.WriteLine("Enter color for instructions: ");
            string input = Console.ReadLine();

            if(Enum.TryParse(input, out TrafficLight trafficLight))
            {
                switch(trafficLight)
                {
                    case TrafficLight.Red:
                        Console.WriteLine("STOP!");
                        break;
                    case TrafficLight.Yellow:
                        Console.WriteLine("Get Ready!");
                        break;
                    case TrafficLight.Green:
                        Console.WriteLine("LIGHTS OUR AND AWAY WE GO!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid command. Please use \"Red\", \"Yellow\", \"Green\"");
            }
        }

        public static void ENums()
        {
            ProductCodes test = ProductCodes.Milk;
            Console.WriteLine((int)test);

            int test2 = 1;
            Console.WriteLine((ProductCodes)2);

            test.ToString();
            Console.WriteLine(test.ToString());

            string test3 = "Tea";
            ProductCodes getProducts;
            bool checkParse = Enum.TryParse(test3, out getProducts);
            Console.WriteLine(checkParse);
        }

        public static void Ex1()//Print the days of the week using an Enum
        {

            Array days = Enum.GetValues(typeof(DaysOfTheWeek));
            Console.WriteLine(days);

            for (int i = 0; i < days.Length; i++)
            {
                DaysOfTheWeek day = (DaysOfTheWeek)days.GetValue(i);
                Console.WriteLine(day);
            }

           
        }
    
        public static void TypeConvertion()
        {
            //Implicit conversion -> doesn't require any additional work or code from your side.

            ushort destinationVar;
            char sourceVar = 'a';
            destinationVar = sourceVar;
            Console.WriteLine($"sourceVar val: {sourceVar}");
            Console.WriteLine($"destinationVar val: {destinationVar}");

            int s = 5;
            long y = 10;
            float z = 7.5f;
            float num1 = 10.25f;
            float num2 = 25.75f;
            y = s; //implicit conversion
            num1 = num2;

            Console.WriteLine(num1);

            //Explicit conversion -> happens when you explicitly ask the compiler 
            //to convert from one data type to another. It requires more code and it's
            //more complex. 

            byte initalVar;
            short varToChange = 7;
            //initalVar = varToChange; //Gives error as the compliter cannot perform this convertion.

            //"Casting" - forcing one data type into another

            byte initVar;
            short sVar = 7;
            initVar = (byte)sVar; //casting the "sVar" int "byte"
            Console.WriteLine($"sourceVar val: {sVar}");
            Console.WriteLine($"destinationVar val: {initVar}");

            // "Overflow" - accures when attemp tot vit a calue into a variable
            // when the value is too big. Use the "checked" & "unchecked"

            byte a;
            short b = 281;
            //a = checked((byte)b); // Unhandled exception. System.OverflowException: Arithmetic operation resulted in an overflow.
            //Console.WriteLine($"sourceVar val: {a}");
            Console.WriteLine($"destinationVar val: {b}");

            Console.WriteLine("_________________________________");
 
            short shortResult, shortVal = 4;
            int integerVal = 67;
            long longResult;
            float floatVal = 10.5F;
            double doubleResult, doubleVal = 99.999;
            string stringResult, stringVal = "27";
            bool boolVal = true;
            Console.WriteLine("Variable Conversion Examples\n");
            doubleResult = floatVal * shortVal;
            Console.WriteLine($"Implicit, -> double: {floatVal} * {shortVal} -> {doubleResult}");
            shortResult = (short)floatVal;
            stringResult = Convert.ToString(boolVal);
            Console.WriteLine($"Explicit, -> short: {floatVal} -> {shortResult}");
            Convert.ToString(doubleVal);
            Console.WriteLine($"Explicit, -> string: \"{boolVal}\" + \"{doubleVal}\" -> " + $"{stringResult}");
            longResult = integerVal + Convert.ToInt64(stringVal);
            Console.WriteLine($"Mixed, -> long: {longResult}");
            Console.ReadKey();
            
            

        }
    }
}