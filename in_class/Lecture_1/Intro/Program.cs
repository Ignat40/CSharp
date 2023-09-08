using System.ComponentModel.Design;
using System.Formats.Asn1;

namespace Ignatcho
{

    class Program
    {
        public static void Main()
        {

            //Data types
            // Mathematical operation:
            //*; /; -; +; ++; %; i--; 

            string stringVar = "Hello World!!";
            int intVar = 100;
            float floatVar = 10.2f;
            char charVar = 'A';
            bool boolVar = true; 
 
            //private variables " _int" 


//------------------------------ Ex. 1 ------------------------------

            int a = 5;
            int b = 10;
            int c = 20;
            int sum = a + b + c;
            Console.WriteLine(sum);

//------------------------------ Ex. 2 ------------------------------

            Console.WriteLine("Enter number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number: ");
            int number3 =  Convert.ToInt32(Console.ReadLine());

            int moshpit = number1 + number2 + number3;
            Console.WriteLine($"The sum is: {moshpit}");

//------------------------------ Ex. 3 ------------------------------

            Console.WriteLine("Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number 3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            float avgNum = (num1 + num2 + num3) / 3;
            Console.WriteLine($"The Average Sum Is {avgNum}");

//------------------------------ Ex. 4 ------------------------------

            Console.WriteLine("Enter radius: ");
            int radius = Convert.ToInt32(Console.ReadLine());

            double area = Math.PI + radius*radius;

            Console.WriteLine($"The are is: {area}");


        }
    }
 }
