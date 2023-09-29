using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Reflection.PortableExecutable;

namespace Arrays
{
    class Program
    {
        public static void Main()
        {
            //Lists();
            //Arr();
            //SumOfElemnts();
            //MaxValue();
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

        public static void MaxValue()
        {
            //------------------------ Ex. 1 ------------------------\\

            int[] arr = {12, 5, 23, 8, 17, 40, 3};
            int max = arr[0]; 

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > max)
                    max = arr[i];
                    
            }
            Console.WriteLine($"The max values is: {max}");

        }

        public static void RemoveDuplicates()
        {
            //------------------------ Ex. 1 ------------------------\\

            int[] duplicatesArray = {12, 32, 12, 58, 3, 5, 28, 2, 12, 58, 2};
            int[] neww = duplicatesArray.Distinct().ToArray();
            Console.WriteLine(neww);
            int duplicate;
            bool isFound = false;

           
        
        
        }

    }
}