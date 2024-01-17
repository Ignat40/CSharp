namespace FinalPrep
{
    class Program
    {
        public static void Main()
        {
            // Chapter 1
            //Chapter1.Greeting();
            //Console.WriteLine(Chapter1.SimpCalc());

            // Chapter 2
            //Console.WriteLine(Chapter2.AreaCalc());
            //Chapter2.Comparinator();

            // Chapter 3
            //Chapter3.TempConvertTask();
            //Chapter3.Quadinator();

            // Chapter 4
            //Chapter4.Patterinator();
            //Chapter4.Factorial();
            //Chapter4.DigitSum();

            // Chapter 5
            //Chapter5.DaysOfTheWeek();
            //Chapter5.StringManipulation();
            //Chapter5.ReverseString();

            // Chapter 6
            //Chapter6.Display();
            //Chapter6.Shop();
            // int num = 5;
            // Console.WriteLine(num);
            // Chapter6.Square(ref num);
            // Console.WriteLine(num);
            // Chapter6.Divide(17, 5, out int divRes, out double remainder);
            // Console.WriteLine($"Result of division: Quotient = {divRes}, Remainder = {remainder}");
            //Chapter6.PrintCoordinates();
            //Console.WriteLine(Chapter6.Multiply(5, 10));
            //Console.WriteLine(Chapter6.Multiply(5.5, 10.2));

            // Chapter 8 
            // Person person1 = new("Rick", 65);
            // Person person2 = new("Morty", 16);
            // Person person3 = new("Summer", 19);
            // Person person3 = new(25);
            // Person person4 = new("Jerry");
            // person1.PrintDetails();
            // person2.PrintDetails();
            // person1.HaveBDay();
            // person2.HaveBDay();
            // person3.HaveBDay();
            // person3.PrintDetails();
            // person4.PrintDetails();
            // MathOperations.Addition(5, 5);
            // MathOperations.Subtraction(5, 5);
            // MathOperations.Multiplication(5, 5);
            // MathOperations.Divition(5, 5);
            // Library library = new();
            // library.DisplayCatalogue();
            // library.AddBook("Book69");
            // library.DisplayCatalogue();
            // library.RemoveBook();
            // library.DisplayCatalogue();

            // Chapter 10
            // Deck deck = new Deck();
            // deck.Shuffle();
            // for(int i = 0; i < 52; i++)
            // {
            //     Card tempCard = deck.GetCard(i);
            //     Console.WriteLine(tempCard.ToString());
            // }

            // Chapte 11
            //Chapter11.HashEx();

            // All in One
            // Book book = new(1234, "Sci-fi", "Harry Poter", "J. K. Rowling");
            // DVD dvd = new("George Lucas", 2.5, "Star Wars", "George Lucas");
            // Console.WriteLine($"Is {book.Title} available: {book.AvailabilityStatus}");
            // Console.WriteLine($"Is {dvd.Title} available: {dvd.AvailabilityStatus}");
            // book.CheckOut();
            // dvd.CheckOut();

            // Student student1 = new("George", 21, 69420, "Computer Science");
            // Professor prof = new("Ye", 46, "Eveytning", 350);
            // Console.WriteLine(student1.ToString());
            // student1.EnrollInCourse("computer science");
            // Console.WriteLine(prof.ToString());
            // prof.TeachCourse("computer scince");

           Product product1 = new Product("Latop", 999.99m);
            Electronics electronic1 = new Electronics("Smartphone", 499.99m, new List<string> { "Black", "White" }, "Samsung", 12);
            // Add stock to products
            product1.AddStock();
            product1.AddStock();
            product1.AddStock();
            product1.AddStock();
            electronic1.AddStock();

            // Show stock quantities
            Console.WriteLine("Stock quantities for Laptop:");
            product1.ShowQuantity();

            Console.WriteLine("\nStock quantities for Smartphone:");
            electronic1.ShowQuantity();

            // Create order items
            OrderItem orderItem1 = new ProductOrderItem("Laptop", 2, 999.99m);
            OrderItem orderItem2 = new ElectronicsOrderItem("Smartphone", 1, 499.99m);

            // Calculate total prices for order items
            orderItem1.CalculatePrice();
            orderItem2.CalculatePrice();



        }
    }

}