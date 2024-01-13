using System.Diagnostics.CodeAnalysis;

namespace FinalPrep
{
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Chapter5
    {
        public static void DaysOfTheWeek() //The user input a number between 1-7 and the program output the corresponding day of the week
        {
            bool flag = false;
            while (!flag)
            {
                Console.WriteLine("Enter number to get the respective day of the week");
                int userInput = Convert.ToInt16(Console.ReadLine());

                if (userInput < 1 || userInput > 7)
                    Console.WriteLine("Out of bounds...");
                else
                {
                    switch (userInput)
                    {
                        case 1:
                            Console.WriteLine(WeekDays.Monday);
                            flag = true;
                            break;
                        case 2:
                            Console.WriteLine(WeekDays.Tuesday);
                            flag = true;
                            break;
                        case 3:
                            Console.WriteLine(WeekDays.Wednesday);
                            flag = true;
                            break;
                        case 4:
                            Console.WriteLine(WeekDays.Thursday);
                            flag = true;
                            break;
                        case 5:
                            Console.WriteLine(WeekDays.Friday);
                            flag = true;
                            break;
                        case 6:
                            Console.WriteLine(WeekDays.Saturday);
                            flag = true;
                            break;
                        case 7:
                            Console.WriteLine(WeekDays.Sunday);
                            flag = true;
                            break;
                    }
                }
            }
        }


        //Create an array of integers. 
        //Write a program to find the sum, average, maximum, and minimum values in the array.
        public static void ArrayOperations()
        {
            int[] array = { 78, 2, -9, 12, 45, 100, 1, 8, 12 };

            int sum = 0;
            foreach (int el in array)
            {
                sum += el;
            }
            Console.WriteLine($"The sum of the array is {sum}");
            Console.WriteLine($"The average of the array is {sum / array.Length}");

            int min = array[0];
            int max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > min)
                    max = array[i];
            }
            Console.WriteLine($"The highest value in the array is {max}");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            Console.WriteLine($"The lowest value in the array is {min}");

        }

        public static void StringManipulation()
        {
            // Easiest way to manipulate a string is to convert it into a char array.
            // This way it's just like manipulating an array: 

            string myString = "A string";
            char[] myChars = myString.ToCharArray();
            foreach (char character in myChars)
            {
                Console.WriteLine(character);
            }

            // You can also get the number of characters(as with in arrays)
            Console.WriteLine($"\"A string\" has {myString.Length} characters");

            //Converting between lower and uppercase letters 
            string allToLower = "THIS WAS CONVERTED TO LOWERCASE LETTERS!";
            string allToUpper = "this was converted to uppercase letters";
            Console.WriteLine(allToLower.ToLower());
            Console.WriteLine(allToUpper.ToUpper());

            //Removing redundant white space from the string 
            string withWhiteSpaces = "     This string has a lot of white spaces       ";
            Console.WriteLine($"Before: {withWhiteSpaces}.");
            Console.WriteLine($"After: {withWhiteSpaces.Trim()}.");

            //Removing specific charactes by specifying them in a char array

            char[] trimChars = { ' ', 'e', 's', '(' };
            string? userResponse = Console.ReadLine(); 
            Console.WriteLine($"Before: {userResponse}");
            Console.WriteLine($"After: {userResponse.ToLower().Trim(trimChars)}");

            

        }

        public static void ReverseString()
        {
            string strToReverse = "racecaR";
            string inversedString = string.Empty;
            for(int i = strToReverse.Length-1; i >= 0; i--)
            {
                inversedString += strToReverse[i];
            }
            Console.WriteLine(inversedString);

        }

    }
}


