using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace BIK
{
    class Program
    {

        static void SayHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
         static void ModifyValue(int num) // passed by reference -> changes the original value
        {
            num = 10;
            Console.WriteLine($"Num = {num}");
            num *= 10;
            Console.WriteLine($"Num x 10 = {num}");
        }
        // static void ModifyValue(int num) // pass by value -> creates a copy of the original and changes the copy
        // {
        //     num = 10;
        // }
        static void Modifystring(ref string str)
        {
            str = "cat";
        }
        
        static void ModifyArray(int[] nums)
        {
            nums[0] = 10;
        }

        static int CalculateNewInt(int num, out int multiplier) //out means that me need to define multiplier
        {
            multiplier = 10;
            return num * multiplier;
        }

        static int MessingWithDeafaults(int x = 5, int y = 10)
        {
            return x * y;
        }

        static int globalNumber = 5;

        static void GlabalTest()
        {
            Console.WriteLine($"From global test -> Globalnumber = {globalNumber}");
        }

        static void GlabalTest2()
        {
            int globalNumber = 10;
            Console.WriteLine($"From global test 2 -> Globalnumber = {globalNumber}");
        }

        static void SecondHour()
        {
            Console.WriteLine($"From hour2 -> {globalNumber}");
            GlabalTest();
            GlabalTest2();

        }

        static double Area(double length, double width)
        {
            return length * width;
        }

        static double Area(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        struct Ingredietns
        {
            public  string Name;
            public  string Amount;

            public readonly void Display()
            {
                Console.WriteLine($"Ingedietns: {Name}, {Amount}");
            }
        }


        
        struct Point
        {
            public int X;
            public int Y;
            public void Display()
            {
                Console.WriteLine($"Point: {X}, {Y}");
            }
        }
        public static int Main(string[] args)
        {
            //FirstHour();
            
            /*
            Stack: 
                Main-> 
                SecondHour()-> 
                run the code in SecondHour() 
                GlobaTest()-> 
                runs the code in globaltest
                <-GlobalTest()
                GlobalTest2()-> 
                runs the conde in globaltest2
                <-GlobalTest2()

            

            if(args.Length > 0)
            {
                foreach(var arg in args)
                {
                    Console.WriteLine($"Hello, {arg}");
                }
            }
          

            Point p = new() {X = 1, Y = 2};
            p.Display();
            


            Console.WriteLine($"Area of rectangle: {Area(5,4)}");
            Console.WriteLine($"Area of a Cirle: {Area(3)}");
            */
            
            Ingredietns[] ingredietns = new Ingredietns[2];
            int ingredietnCount = 0;
            string recipeName = args.Length > 0 ? args[0] : "Unnamed recipe";

            bool stopper = true;

            while(stopper)
            {
               DisplayRecipe(recipeName);

               string? choice = GetMenuChoice(); 

               stopper = HandleMenuChoice(choice, ref ingredietns, ref ingredietnCount, ref recipeName);


            }


            return 0;
        }

        static void AddIngredients(ref Ingredietns[] ingredietns, ref int ingredietnCount)
        {
            if(ingredietnCount >= ingredietns.Length)
            {
                Array.Resize(ref ingredietns, ingredietns.Length * 2);
            }
            
            Console.WriteLine("Enter the ingredient name: ");
            string? name = Console.ReadLine();
            Console.WriteLine("Enter the amount ");
            string? amount = Console.ReadLine();
            ingredietns[ingredietnCount++] = new Ingredietns{Name = name, Amount = amount};

        }
        static void RemoveIngredients(Ingredietns[] ingredietns, ref int ingredietnCount)
        {
            Console.WriteLine("Enter the ingredients index for remove: ");
            if(int.TryParse(Console.ReadLine(), out int index) && index < ingredietnCount && index >= 0)
            {
                for (int i = index; i < ingredietnCount -1; i)
                {
                    ingredietns[i] = ingredietns[i+1];
                }
                ingredietnCount--;

                
            }
            else
            {
                Console.WriteLine("Invalid index...");
            }
        }

        static bool HandleMenuChoice(string? choice, ref Ingredietns[] ingredietns, 
        ref int ingredietnCount, ref string recipeName)
        {
            if(choice == "1")
            {
                AddIngredients(ref ingredietns, ref ingredietnCount);
                return true; 
            }
            else if(choice == "2")
            {
                RemoveIngredients(ingredietns, ref ingredietnCount);
                return true;
            }
            else if(choice == "3")
            {
                DisplayIngredients(ingredietns, ingredietnCount, recipeName);
                return true;
            }
            else if(choice == "4")
            {
                ChangeRecipeName(ref recipeName);
                return true;
            }
            else if(choice == "5")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invlied choice. Try Again...\n");
            }
        }

        static void ChangeRecipeName(ref string? recipeName)
        {
            Console.WriteLine("Enter the new recipe name: ");
            Console.ReadLine();
        }

        static string? GetMenuChoice()
        {
            Console.WriteLine($"1: Add Ingredients");
            Console.WriteLine($"2: Move Ingrediensts");
            Console.WriteLine($"3: Dispaly Ingredietns");
            Console.WriteLine($"4: Change Recipe Name");
            Console.WriteLine($"5: Quit");

            Console.WriteLine("Enter your choice: ");
            return Console.ReadLine();
        }

        static void DisplayRecipe(string name)
        {
            Console.WriteLine($"Current recipe: {name}");
        }

        static void DisplayIngredients(Ingredietns[] ingredietns, int ingredietnCount, string recipeName)
        {
            Console.WriteLine($"Ingredients for recipe: {recipeName}");
            for (int i = 0; i < ingredietnCount; i++)
            {
                ingredietns[i].Display();
            }
        }

         static void FirstHour()
        {
            //Value Types -> passed by value
            // - int, double, float, struct


            //Reference Types -> pass by reference
            // - classes, string, arrays

            //Metadata: Lookup table; Properties; Functoin Definition

            //Main memory loactions - 1. Stack               2. Heap
            //                          -> Main()              ->objets
            //                          ->SayHelloWorld()      ->global variables
            //                             <-
            //

            //SayHelloWorld();
            
        
            int value = 5;
            Console.WriteLine($"Value = {value}");                        
            ModifyValue(value);
            Console.WriteLine($"Value = {value}");
        

            string word = "dog";
            word = "cat";
            word = "dog"; // Creates new memory for every new instance. The old one goes in the garbadge collection. 
            word = "cat + dog";
            Console.WriteLine($"Value = {word}");                        
            Modifystring(ref word);
            Console.WriteLine($"Value = {word}");


            int[] ints = new int[]{1,2,3,4,5};
            Console.WriteLine($"Array -> {ints[0]}");
            ModifyArray(ints);
            Console.WriteLine($"Array -> {ints[0]}");
            

            int val = 5;
            Console.WriteLine($"Value -> {val}");
            int number = CalculateNewInt(val, out int multiplier);
            Console.WriteLine($"MULTIPLIER -> {multiplier}");
            Console.WriteLine($"number -> {number}");
            Console.WriteLine($"Value -> {val}");
            

            int xTimesY = MessingWithDeafaults();
            Console.WriteLine($"Before -> {xTimesY}");
            xTimesY = MessingWithDeafaults(2, 3);
            Console.WriteLine($"After -> {xTimesY}");
            xTimesY = MessingWithDeafaults(20);
            Console.WriteLine($"Only setting X -> {xTimesY}");
            xTimesY = MessingWithDeafaults(y: 5); // -> "Named parameter" 
            Console.WriteLine($"Named patameter -> {xTimesY}");
            xTimesY = MessingWithDeafaults(y: 5, x: 100); // -> "Named parameter" 
            Console.WriteLine($"Named patameter -> {xTimesY}");
           

        }

    }
}