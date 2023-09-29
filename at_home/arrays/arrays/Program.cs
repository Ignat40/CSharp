using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        public static void Main()
        {
            //Lists();
            //Arr();
            //SumOfElemnts();
            //AvgOfArray();
            //MaxValue();
            //SecondMaxValue();
            //FindMissing();
            //FindIfDuplicates();
            RemoveDuplicates();
        }

        public static void Arr()
        {

            //structure of the arrays 
            //type of the variable + [] + name
            //Every item has an index - 0, 1, 2, 3,... 
            string[] arr = { "one", "two", "three", "four" };

            //Print out one word from the array
            //Console.WriteLine(array[0]);

            for (int i = 0; i < arr.Length; i++)
            {
                int rank = i + 1;//printng rank
                Console.WriteLine(rank + ". " + arr[i]); // prints every item of the array 
            }

            string[] moives = new string[4]; // empty array that holds 4 items

            Console.WriteLine("Type in four movies: ");
            // moives[0] = Console.ReadLine();
            // moives[1] = Console.ReadLine();
            // moives[2] = Console.ReadLine();
            // moives[3] = Console.ReadLine();

            for (int i = 0; i < moives.Length; i++)
            {
                moives[i] = Console.ReadLine();
            }

            Console.WriteLine("\nHere thy are alphabetically");
            Array.Sort(moives);

            for (int i = 0; i < moives.Length; i++)
            {
                Console.WriteLine(moives[i]);
            }


        }

        public static void Lists() // We don't need to specify the lenght of the list, like we do in the arrays
        {
            //we need to add namespace System.Collections.Genreic;

            //List + <type of the list> + name = new List<type>();

            List<string> shoppingList = new List<string>(); // -> empty list

            shoppingList.Add("Dreams");
            shoppingList.Add("Dals;kdj");
            shoppingList.Add("Dals;kdj");
            shoppingList.Add("Dals;kdj");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }

            shoppingList.Remove("Dreams");
            shoppingList.RemoveAt(1);

            Console.WriteLine("----------------------");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }


        }

        public static void SumOfElemnts()
        {
            //------------------------ Ex. 1 ------------------------\\

            int[] arr = { 1, 4, 2, 6, 5, 2, 10 };
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine($"The sum is: {sum}");

        }

        public static void AvgOfArray()
        {
            //------------------------ Ex. 2 ------------------------\\

            int[] avgArr = {3, 56, 97, 43, 25, 72, 74, 40, 82, 84, 24, 51, 28, 87, 81};
            double sum = 0;
            double avg = 0;
            for (int i = 0; i < avgArr.Length; i++)
            {
                sum += avgArr[i];
                avg = sum / avgArr.Length;

            }

            Console.WriteLine($"The average is: {avg}");

        }

        public static void MaxValue()
        {
            //------------------------ Ex. 3 ------------------------\\

            int[] arr = {12, 5, 23, 8, 17, 40, 3};
            int max = arr[0]; 

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > max)
                    max = arr[i];
                    
            }
            Console.WriteLine($"The max values is: {max}");

        }

        public static void SecondMaxValue()
        {
            //------------------------ Ex. 4 ------------------------\\

            int[] arr = {13, 17, 85, 49, 66, 25, 46, 65, 4, 23, 3, 71, 44, 12, 50, 62, 33, 82, 47, 36};
            int max = arr[0]; 
            int secondBiggest = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > max)
                    max = arr[i];
                else if(secondBiggest < arr[i] && secondBiggest < max)
                    secondBiggest = arr[i];
                    
            }
            Console.WriteLine($"The second max values is: {secondBiggest}");

        }

        public static void FindMissing()
        {
            //------------------------ Ex. 5 ------------------------\\

            int[] arrToFind = {68, 65, 30, 87, 21, 17, 96, 70, 64, 34, 14, 90, 86, 31, 29, 40};
            bool isFound = false;

            Console.WriteLine("Looking for number: ");
            if(int.TryParse(Console.ReadLine(), out int input))
            {
                for (int i = 0; i < arrToFind.Length; i++)
                {
                    if(input == arrToFind[i])
                        isFound = true;
                }
            }
            else
            {
                Console.WriteLine("Couldn't covert. Please run again...");
            }

            if(isFound)
                Console.WriteLine($"The list contains number {input}");
            else    
                Console.WriteLine($"Not found...");

        }


        public static void FindIfDuplicates()
        {
            //------------------------ Ex. 6 ------------------------\\

            int[] duplicatesArray = {1, 2, 3, 4, 5, 6, 6, 7, 8, 9};
            bool isFound = false;
            int duplicate = duplicatesArray[0];

            for (int i = 0; i < duplicatesArray.Length; i++)
            {
                for (int j = 1; j < duplicatesArray.Length; j++)
                {
                    if(i != j && duplicatesArray[i] == duplicatesArray[j])
                        isFound = true;                   
                }
            }

            if(isFound)
                Console.WriteLine("Duplicates found!");
            else
                Console.WriteLine("Free of duplciates!");
           
        }
        
        public static void RemoveDuplicates()
        {
            //------------------------ Ex. 7 ------------------------\\

            int[] duplicatesArray = {1, 2, 3, 4, 5, 6, 6,6,6,6,6,6,6,6, 7, 8, 9};
            int[] freeOfDuplicates = duplicatesArray.Distinct().ToArray();
            for (int i = 0; i < freeOfDuplicates.Length; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}