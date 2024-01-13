namespace FinalPrep
{
    class Chapter1
    {
        // Task 1. - Create a probgram that prints Hello World
        public static void Greeting()
        {
            Console.WriteLine("Hello World!");
        }

        // Task 2. - Create a very simple calculater that takes 
        // as input and performs basic operations of two numbers

        public static (double sum, double dif, double product, double quotient) SimpCalc()
        {
            Console.WriteLine("Enter value for num1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value for num2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;
            double dif = num1 - num2;
            double product = num1 * num2;
            double quotient = (num2 != 0) ? num1 / num2 : double.NaN;

            return (sum, dif, product, quotient);
        }


    }
}