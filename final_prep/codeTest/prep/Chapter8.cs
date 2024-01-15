namespace FinalPrep
{
    // OOP Basics
    // Constructors and Destructos
    // Static and Instance Members
    class Person
    {
        public string? Name;
        public int Age;
        public static int TotalPeople;
        public Person(string? Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
            TotalPeople++;
        }

        public Person(string? Name)
        {
            this.Name = Name;
        }

        public Person(int Age)
        {
            this.Age = Age;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        public void HaveBDay()
        {
            Age++;
            Console.WriteLine(Age);
            TotalPeople++;
            Console.WriteLine(TotalPeople);
        }

    }

    static class MathOperations
    {
        public static void Addition(double num1, double num2)
        {
            Console.WriteLine(num1 + num2);
        }
        public static void Subtraction(double num1, double num2)
        {
            Console.WriteLine(num1 - num2);
        }
        public static void Multiplication(double num1, double num2)
        {
            Console.WriteLine(num1 * num2);
        }
        public static void Divition(double num1, double num2)
        {
            Console.WriteLine(num1 / num2);
        }
    }

    class Library
    {
        public int TotalBooks;
        public string[]? Catalogue = {"book1", "book2",  "book1", "book2", "book3"};

        public void AddBook(string bookName)
        {
           Array.Resize(ref Catalogue, Catalogue.Length + 1);
           Catalogue[^1] = bookName;
           Console.WriteLine("Book added!");
        }

        public void RemoveBook()
        {
            Array.Resize(ref Catalogue, Catalogue.Length - 1);
            Console.WriteLine("Removed successfully!");
        }
        public void DisplayCatalogue()
        {
            foreach(var book in Catalogue)
            {
                Console.Write(book + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Total count is: {Catalogue.Length}");
        }
    }

}