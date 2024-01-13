using System.Data;

namespace FinalPrep
{
    class Chapter4
    {
        // Create a program that generats and prins a number pattern

        public static void Patterinator()
        {
            Console.WriteLine("Choose pattern: ");
            Console.WriteLine("1. Downwards sign triangle");
            Console.WriteLine("2. Upwards sign triangle");
            Console.WriteLine("3. Downwards number triangle");
            Console.WriteLine("4. Downwards sing pyramid");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    UpSignTrig();
                    break;

                case "2":
                    DownSignTrig();
                    break;

                case "3":
                    NumberTrig();
                    break;
                
                case "4":
                    DownSignPyd();
                    break;

            }

        }
        public static void UpSignTrig()
        {
            Console.WriteLine("Enter the size of the triangle:");
            int size = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= size; i++)
            {
                Console.WriteLine("");
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
            }
        }
        public static void DownSignTrig()
        {
            Console.WriteLine("Enter the size of the triangle:");
            int size = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= size; i++)
            {
                Console.WriteLine("");
                for (int j = size; j >= i; j--)
                {
                    Console.Write("*");
                }
            }
        }
        public static void NumberTrig()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("");
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
            }
        }
        public static void DownSignPyd()
        {
            Console.WriteLine("Enter the size of the triangle:");
            int size = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Factorial() // for the million'th time :)
        {
            int number = 5;
            int fact = 1;
            
            for(int i = 1; i<=number; i++)
            {
                int factaaljsdhf = fact * i;
                fact = factaaljsdhf;
            }
            Console.WriteLine(fact);
           

        }

        // Sums the digits of a number 
        public static void DigitSum()
        {
            Console.WriteLine("Enter positvite integer:");
            int number = Convert.ToInt16(Console.ReadLine());

            int sumOfDigits = 0; 
            while(number != 0)
            {
                sumOfDigits += number % 10;
                number /= 10;
            }
            Console.WriteLine(sumOfDigits);
        }



    }
}