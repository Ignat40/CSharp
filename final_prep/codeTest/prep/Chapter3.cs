using System.Diagnostics.Contracts;
using System.Security.AccessControl;

namespace FinalPrep
{
    class Chapter3
    {
        // Build a program that converts temperatures between Celsius and Fahrenheit. 
        // Allow the user to choose the conversion direction and input the temperature.

        public static void TempConvertTask()
        {
            Console.WriteLine("Choose one of the following convertions: \n1. From C to F \n2. From F to C");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    CtoF();
                    break;

                case "2":
                    FtoC();
                    break;

                default:
                    break;
            }

        }
        private static void CtoF()
        {
            Console.WriteLine("Enter Celsius: ");
            double cels = Convert.ToDouble(Console.ReadLine());
            double convertion = 1.8 * cels + 32;
            Console.WriteLine($"{cels} Celsius is {convertion} Fahrenheit!");
        }

        private static void FtoC()
        {
            Console.WriteLine("Enter Fahrenheit: ");
            double fahr = Convert.ToDouble(Console.ReadLine());
            double convertion = (fahr - 32) * 0.56;
            Console.WriteLine($"{fahr} Celsius is {convertion} Fahrenheit!");
        }

        public static void Quadinator() //for the hundreth time :)))
        {
            Console.WriteLine("Your eqation is in the form of: Ax^2 + Bx + C");
            Console.WriteLine("Enter value for A: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value for B: ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value for C: ");
            double C = Convert.ToDouble(Console.ReadLine());

            double D = Math.Sqrt(B * B - 4 * A * C);
            double X1 = (-B + D) / 2 * A;
            double X2 = (-B - D) / 2 * A;

            Console.WriteLine($"Root 1: {X1}");
            Console.WriteLine($"Root 2: {X2}");
        }

    }
}