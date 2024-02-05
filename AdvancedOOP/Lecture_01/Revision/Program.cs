using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Xml.XPath;

namespace Lecture_1
{

    public class Program
    {
        static int numberOfLoops;
        static int numberOfIterations;
        static int[] loops;
        public static void Main()
        {
            // Console.Write("N = ");
            // numberOfLoops = int.Parse(Console.ReadLine());
            // Console.Write("K = ");
            // numberOfIterations = int.Parse(Console.ReadLine());
            // loops = new int[numberOfLoops];
            // Ex1(0);

            Console.Write("N = ");
            numberOfLoops = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            numberOfIterations = int.Parse(Console.ReadLine());

        }

        public static long Fib(int number) // Example on inefficiant recursive solution
        {
            if (number <= 2)
                return 1;
            else
                return Fib(number - 1) + Fib(number - 2);
        }

        // public static long EfficientFib(int number)
        // {
        //     if (0 == numbers[number])
        //     {
        //         numbers[number] = Fib(number - 1) + Fib(number - 2);
        //     }
        //     return numbers[number];
        // }

        public static int RecFact(int number)
        {
            if (number <= 0)
                return 1;
            else
                return number * RecFact(number - 1);
        }

        //------------------  Write a program to simulate n nested loops from 1 to n. ------------------\\

        // public static void Ex1(int currentLoop)
        // {

        //     if (currentLoop == numberOfLoops)
        //     {
        //         PrintLoops();
        //         return;
        //     }
        //     for (int counter = 1; counter <= numberOfIterations; counter++)
        //     {
        //         loops[currentLoop] = counter;
        //         Ex1(currentLoop + 1);
        //     }


        // }

        // static void PrintLoops()
        // {
        //     for (int i = 0; i < numberOfLoops; i++)
        //     {
        //         Console.Write("{0} ", loops[i]);
        //     }
        //     Console.WriteLine();
        // }

    }

}