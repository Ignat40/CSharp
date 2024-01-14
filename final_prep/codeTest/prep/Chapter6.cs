using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Xml.Schema;
using Microsoft.VisualBasic;

namespace FinalPrep
{
    struct ShopItem
    {
        public string itemName;
        public int unitCount; 
        public double unitCost;
        public double Price(int count, double cost) => count*cost;
        public string Information()
        {
            string totalInfo = unitCount + " " + itemName + " " + "items at " + "$" + unitCost + " " + "each " + "with total cost of " + "$" +  unitCost*unitCount;
            return totalInfo;
        }
    }
    class Chapter6
    {
        // Write an application that uses takes two user inputs - 
        // a string and an integer variable, respectively. 
        // Then display those values. Use tupels 

        public static void Display()
        {
            var result = GetUserInput();

            Console.WriteLine($"The string: {result.Item1}");
            Console.WriteLine($"The integer: {result.Item2}");
        }

        static (string, int) GetUserInput()
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();
            return(word, number);

        }

        // Implement a function GetCoordinates that takes two integers and returns a tuple representing the coordinates (x, y).

        public static void PrintCoordinates()
        {
            var coordiantes = GetCoordinates();
            Console.WriteLine(coordiantes);
        }

        static(int x, int y) GetCoordinates()
        {
            Console.WriteLine("Enter value for X: ");
            int x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter value for Y: ");
            int y = Convert.ToInt16(Console.ReadLine());
            return(x,y);
        }

        // Create a struct that includes an itemname, unitcount and unitcost of a product
        // Write a struct function that that returns the total price. 
        // Add another function that returns a formated string as follows:
        // Order Information: <unit count> <item name> items at $<unit cost> each, total cost $<total cost>

        public static void Shop()
        {
            ShopItem shopItem = new();
            string name = shopItem.itemName = "Steak";
            double price = shopItem.unitCost = 20.50;
            int quantity = shopItem.unitCount = 3;
            Console.WriteLine(shopItem.Price(quantity, price));
            Console.WriteLine(shopItem.Information());
        }


        // Write a function Square that takes an integer as a parameter
        // and modifies it in place by squaring its value using the ref keyword.

        public static void Square(ref int a)
        {
            a *= a;
            Console.WriteLine(a);
        }

        // Create a function Divide that takes two integers as parameters. 
        // Use the out keyword to return the result of integer division and the remainder separately.

        public static void Divide(int num1, int num2, out int divRes, out double remainder)
        {
            divRes = num1/num2;
            remainder = num1 & num2;
        }


        // Create two overloaded functions named Multiply:
        // One that takes two integers and returns their product.
        // Another that takes two doubles and returns their product.

        public static int Multiply(int a, int b)=>a*b;
        public static double Multiply(double a, double b)=>a*b;

    }
}