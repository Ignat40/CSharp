using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace ClassesExercises
{
    /// <summary>
    /// Access Modifiers:
    /// Public -> have access from anywhere in the assembly 
    /// Private  -> have access only from the same class
    /// Protected -> 
    /// Internal
    /// Protected Internal
    /// Private Protected 
    /// </summary>
    /// 

    public class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiplicatoin(int a, int b)
        {
            return a * b;
        }
        public static int Devition(int a, int b)
        {
            return a / b;
        }
    }

    public class Person
    {
        public string? Name; 
        public int Age;
        public bool IsMarried; 

        public static void PresentPerson(Person person)
        {
            Console.WriteLine($"Hi, I am {person.Name}, i'm {person.Age} years old. \nMarried status: {person.IsMarried}");
        }
    }
    public class Shape
    {
        public static int Area(int width, int height)
        {
            return width * height;
        }
        public static int Parameter(int width, int height)
        {
            return 2*(width + height);
        }
    }

    class Student
    {
        public string? StudentName {get; set;}
        public int RowNumber {get; set;}
        public int MathGrade {get; set;}
        public int GeographyGrade {get; set;}
        public int HistoryGrade {get; set;}

        public Student(string studetnName, int rowNumber, int mathGrade, int geoGrade, int historyGrade)
        {
            StudentName = studetnName;
            RowNumber = rowNumber;
            MathGrade = mathGrade;
            GeographyGrade = geoGrade;
            HistoryGrade = historyGrade;
        }

        public Student()
        {
        }

        public double AverageGrade()
        {
            double avg = (MathGrade + GeographyGrade + HistoryGrade)/3;
            return avg;
        }
        
    }
    class Car
    {
        public string? Model {get; set;}
        public int YearOfManufactioring {get; set;}
        public string? Engine {get; set;}
        public Car()
        {
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year of Manufactoring: {YearOfManufactioring}");
            Console.WriteLine($"Engine: {Engine}");
        }
    }
    // class Program
    // {
    //     public static void Main()
    //     {
    //         Calculator calculator = new();
    //         int num1 = 10;
    //         int num2 = 5;
    //         Console.WriteLine(Calculator.Add(num2, num1));
    //         Console.WriteLine(Calculator.Subtract(num2, num1));
    //         Console.WriteLine(Calculator.Multiplicatoin(num2, num1));
    //         Console.WriteLine(Calculator.Devition(num2, num1));

    //         Console.WriteLine("\n--------------------------------------------\n");

    //         Person person = new();
    //         person.Name = "Martin";
    //         person.Age = 20;
    //         person.IsMarried = false;
    //         Person.PresentPerson(person);

    //         Person person2 = new()
    //         {
    //             Name = "Ivan",
    //             Age = 25,
    //             IsMarried = true
    //         };
    //         Person.PresentPerson(person2);

    //         Console.WriteLine("\n--------------------------------------------\n");

    //         Shape square = new();
    //         Console.WriteLine($"The area of the sqare is {Shape.Area(5, 10)}");
    //         Console.WriteLine($"The parameter of the sqare is {Shape.Parameter(5, 10)}");

    //         Console.WriteLine("\n--------------------------------------------\n");

    //         Student student1 = new()
    //         {
    //             StudentName = "Ivan Ivanov", 
    //             RowNumber = 10,
    //             GeographyGrade = 6,
    //             MathGrade = 4,
    //             HistoryGrade = 5
    //         };
    //         double avgGrade = student1.AverageGrade();
    //         Console.WriteLine("Name: " + student1.StudentName);
    //         Console.WriteLine("Row: " + student1.RowNumber);
    //         Console.WriteLine("Average Grade: " + avgGrade);

    //         Console.WriteLine("\n--------------------------------------------\n");

    //         Car car = new()
    //         {
    //             Model = "Shelby",
    //             YearOfManufactioring = 1964,
    //             Engine = "V8 with 400 HP"
    //         };
    //         car.DisplayInfo();

    //     }
    // }

}