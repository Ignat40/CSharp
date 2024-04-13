using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Text;


namespace Practice
{
    class Program
    {
        public static void Main()
        {
            //Console.WriteLine(CaesarCipherDecode("Ebiil", 3));
            Console.WriteLine(CaesarCipherDecode("Gur", 13));
            Console.WriteLine(CaesarCipherEncode("The", 13));
        }

        public static void guessTheNumber()
        {
            //------------------------- Ex. 1 -------------------------\\

            Random random = new Random();
            int toGuess = random.Next(1, 101);
            int myGuess;
            bool isGuessed = false;

            Console.WriteLine("Let's play a game!");
            Console.WriteLine("Guess my number between 1 - 100! ");

            while (true)
            {
                Console.WriteLine($"Your guess: ");

                if (!int.TryParse(Console.ReadLine(), out myGuess))
                {
                    Console.WriteLine("Invalid input! Please enter integer: ");
                    continue;
                }

                if (myGuess < toGuess)
                {
                    Console.WriteLine("Try bigger \n");
                    continue;
                }

                if (myGuess > toGuess)
                {
                    Console.WriteLine("Try lower \n");
                    continue;
                }
                else
                {
                    Console.WriteLine($"You Win! My number was {toGuess}");
                    isGuessed = true;
                }

                if (isGuessed)
                    break;

            }

        }

        public static void CombineDigits()
        {
            //------------------------- Ex. 2 -------------------------\\

            int temp = 0;
            int sum = 0;

            Console.WriteLine("This program will sum the digits of the number you enter!");

            while (true)
            {
                Console.WriteLine("Enter your number: ");

                if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
                {
                    while (number > 0)
                    {
                        temp = number % 10;
                        sum += temp;
                        number /= 10;
                    }
                    Console.WriteLine($"Sum: {sum}");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again! \n");
                    continue;
                }
            }
        }

        public static void TempConverter()
        {
            //------------------------- Ex. 3 -------------------------\\
            double userInput;
            Console.WriteLine("This application will convert degrees of your choice! \n");

            while (true)
            {
                Console.WriteLine("1. Celsius to Farenheit");
                Console.WriteLine("2. Farenheit to Celsius");

                if (!int.TryParse(Console.ReadLine(), out int input) &&
                    input <= 0 && input > 2)
                {
                    Console.WriteLine("Invalid input...\tTry again: ");
                    continue;
                }
                if (input == 1)
                {
                    Console.WriteLine("Enter degree in Celsius: ");
                    userInput = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"In Farenheit: {(userInput * 1.8) + 32}");
                    break;
                }
                else if (input == 2)
                {
                    Console.WriteLine("Enter degree in Farenheit: ");
                    userInput = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"In Celsius: {(userInput / 1.8) - 32}");
                    break;
                }
                else
                {
                    break;
                }
            }

        }

        public static void Fibonacci()
        {
            //------------------------- Ex. 4 -------------------------\\

            Console.WriteLine("Fibbonaci numbers!");

            int limit = Convert.ToInt32(Console.ReadLine());
            int previous = 0;
            int current = 1;

            for (int i = 0; i <= limit; i++)
            {
                int next = previous + current;
                previous = current;
                current = next;

                Console.WriteLine(next);
            }

        }

        public static void ReverseString()
        {
            //------------------------- Ex. 5 -------------------------\\

            Console.WriteLine("Enter string to reverse: ");
            string strToEnter = Console.ReadLine();
            char[] charArray = strToEnter.ToCharArray();
            string strToReverse = string.Empty;

            for (int i = charArray.Length - 1; i > -1; i--)
            {
                strToReverse += charArray[i];
            }

            Console.WriteLine($"{strToEnter} reversed is: {strToReverse}");
        }

        public static void Palindrome()
        {
            //------------------------- Ex. 6 -------------------------\\
            Console.WriteLine("Write string to check is palindrome: ");
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            string revresed = string.Empty;

            for (int i = charArray.Length - 1; i > -1; i--)
            {
                revresed += charArray[i];
            }

            if (revresed == input)
                Console.WriteLine($"{input} is palindrome!");
            else
                Console.WriteLine($"{input} is NOT palindrome!");
        }

        public static void PrimeNumber()
        {
            //------------------------- Ex. 6 -------------------------\\
            Console.WriteLine("Enter number to see if Prime: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int a = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine("{0} is a Prime Number", n);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
        }
        public static string SentanceSmash(string[] words)
        {
            //------------------------- Ex. 7 -------------------------\\
            string sentance = "";
            foreach (var item in words)
            {
                sentance += item + ".";
            }
            sentance = sentance.Remove(sentance.Length - 1);
            return sentance;
        }


        public static string CaesarCipherDecode(string message, int key)
        {
            StringBuilder decodedMessage = new();

            foreach (var character in message)
            {
                if (char.IsAsciiLetter(character))
                {
                    char initialChar = char.IsUpper(character) ? 'A' : 'a';
                    char decodedChar = (char)(((character - initialChar + key + 26) % 26) + initialChar);
                    decodedMessage.Append(decodedChar);
                }
                else
                    decodedMessage.Append(character);
            }

            Console.WriteLine(19 % 26);
            return decodedMessage.ToString();

        }

        public static string CaesarCipherEncode(string message, int key)
        {
            StringBuilder encodedMessage = new();

            foreach (var c in message)
            {
                if (char.IsAsciiLetter(c))
                {
                    char initialChar = char.IsUpper(c) ? 'A' : 'a';
                    char encodedChar = (char)(((c - initialChar + key) % 26) + initialChar);
                    encodedMessage.Append(encodedChar);
                }
                else
                    encodedMessage.Append(c);
            }

            return encodedMessage.ToString();
        }


    }
}