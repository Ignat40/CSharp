using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Classes
{
    //Encapsulation -> enables us to hide data (double balance) 
    class BankAccount
    {
        private double balance;
        public void Deposit(double amount)
        {
            balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount < -balance)
            {
                balance -= amount;
            }
        }
        public double CheckBalance()
        {
            return balance;
        }
    }

    //Inharetance -> allows you to get access to properties of a base(parent class)
    public class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        private bool isAcessible { get; set; } // cannot be seen outside this class
        protected bool isAccessible { get; set; } // cannot be seen outside this class
    }
    public class Studenet : Person
    {
        public string? Major { get; set; }

    }
    public class Teacher : Person
    {
        public string? Subject { get; set; }
    }

    // public class Program : Person
    // {
    //     public static void Main()
    //     {
    //         Calculator calculator = new();
    //         int num1 = 5;
    //         int num2 = 2;
    //         Console.WriteLine(calculator.Subtract(num2, num1));

    //     }
    // }

    //Polymorphism -> allows one object to do multiple things (for example swiss knife)
    // public class Animal
    // {
    //     public virtual void MakeSound() //"virtual" -> allows the function to be overrridden
    //     {
    //         Console.WriteLine("The animal makes a sound");
    //     }
    // }
    // public class Dog : Animal
    // {
    //     public override void MakeSound()
    //     {
    //         base.MakeSound();
    //         Console.WriteLine("Woof!");
    //     }
    // }

    // public class Cat : Animal
    // {
    //     public override void MakeSound()
    //     {
    //         base.MakeSound();
    //         Console.WriteLine("Meaw");
    //     }
    // }

    //Abstraction -> trying to hide all the complexity of things. 
    public abstract class Animal2
    {
        public abstract void MakeSound();
        public void PetAnimal()
        {
            Console.WriteLine("You can pet the animal");
        }
    }

    public class Dog2 : Animal2
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
        public void PetDog()
        {
            base.PetAnimal();
            Console.WriteLine("You have pet the dog.");
        }
    }
    //Implement a class called Calculator with a static method Add that takes two integers and returns their sum,
    // and an instance method Subtract that takes two integers and returns their difference.
    class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }

    }

    //Create a Vehicle class with a method Move
    // and a Car class that inherits from Vehicle. Override the Move method in Car.
    class Vehicle
    {
        public virtual void Move()
        {
            Console.WriteLine("The car moves");
        }
    }
    class Car : Vehicle
    {
        public override void Move()
        {
            base.Move();
            Console.WriteLine("The car is moving");
        }
    }
    class Sedan : Car
    {
        public override void Move()
        {
            base.Move();
            Console.WriteLine("The sedan is moving");
        }
    }

    //Create an abstract class Shape with an abstract method Draw. 
    //Create two derived classes Circle and Rectangle that override Draw.


    
    abstract class Shape
    {
        
        public abstract void Draw();
    }

    
    class Circle : Shape
    {
        private int radius;

        
        public Circle(int radius)
        {
            this.radius = radius;
        }

        
        public override void Draw()
        {
            Console.WriteLine($"Drawing a circle with radius {radius}");
        }
    }

  
    class Rectangle : Shape
    {
        private int width;
        private int height;

        
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        
        public override void Draw()
        {
            Console.WriteLine($"Drawing a rectangle with width {width} and height {height}");
        }
    }
    //---------------- Zoo Keep

    class Program
    {
        static void Main(string[] args)
        {
            // Creating objects of Circle and Rectangle
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(3, 4);

            // Calling the Draw method for Circle and Rectangle
            circle.Draw();
            rectangle.Draw();
        }
    }


}