using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace foreachLoop
{
    class Prorgam
    {
        public static void Main()
        {
            Ex6();
        }

        public static void Ex1() //Find the sum on an array
        {
            int[] numbers = { 1, 2, 3, 4, 5, };
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine($"The sum is: {sum}");
        }
        public static void Ex2() //Take input string from the user and output every letter in a new line
        {
            Console.WriteLine("Enter string: ");
            string? input = Console.ReadLine();

            foreach (char charachter in input)
            {
                Console.WriteLine(charachter);
            }
        }
        public static void Ex3() //Find all even numbers in array
        {
            int[] evenArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int number in evenArray)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }
        }

        public static void Ex4() //Count all the vowels in the strig inputted by the user
        {
            Console.WriteLine("Enter a string: ");
            string? input = Console.ReadLine();
            int counter = 0;
            foreach (char vowel in input)
            {
                if (vowel == 'a' || vowel == 'o' || vowel == 'u' || vowel == 'e' || vowel == 'i')
                {
                    counter += 1;
                }
            }
            Console.WriteLine($"There are {counter} vowels in the string");
        }

        public static void Ex5() //Find Max Number In Array
        {
            int[] arrayMax = { 3, 10, 90, 74, 20, 7, 3 };
            int max = arrayMax[0];

            foreach (int num in arrayMax)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine($"The max of the array is: {max}");
        }

        public static void Ex6() //Find the longest word
        {

            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            string longestWord = "";

            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            Console.WriteLine($"Longest word in the sentence: {longestWord}");
        }

    }
}