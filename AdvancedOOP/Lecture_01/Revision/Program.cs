using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Xml.XPath;

namespace Lecture_1
{

    public class Program
    {
        static long[]? numbers;
        public static void Main()
        {
            Console.Write("Enter value: ");
            int input = int.Parse(Console.ReadLine());

            numbers = new long[input + 2];
            numbers[1] = 1;
            numbers[2] = 1;

            long result = EfficientFib(input);
            Console.WriteLine("fib({0}) = {1}", input, result);
        }

        public static long Fib(int number) // Example on inefficiant recursive solution
        {
            if (number <= 2)
                return 1;
            else
                return Fib(number - 1) + Fib(number - 2);
        }

        public static long EfficientFib(int number)
        {
            if (0 == numbers[number])
            {
                numbers[number] = Fib(number - 1) + Fib(number - 2);
            }
            return numbers[number];
        }

        public static int RecFact(int number)
        {
            if (number <= 0)
                return 1;
            else
                return number * RecFact(number - 1);
        }
    }

}