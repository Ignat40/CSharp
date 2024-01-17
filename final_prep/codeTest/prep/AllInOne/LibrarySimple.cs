namespace FinalPrep
{
    abstract class LibraryItem
    {
        public string? Title;
        public string? Author;
        public bool AvailabilityStatus = true;

        public virtual void CheckOut()
        {
            AvailabilityStatus = false; 
        }
    }

    class Book : LibraryItem
    {
        int ISBN;
        string? Genre; 

        public Book(int ISBN, string? Genre, string? Title, string? Author) : base()
        {
            this.ISBN = ISBN;
            this.Genre = Genre;
            this.Title = Title;
            this.Author = Author;
        }

        public override void CheckOut()
        {
            AvailabilityStatus = false;
            Console.WriteLine("This book is not availabe...");
        }
    }

    class DVD : LibraryItem
    {
        string? Director;
        double Runtime;

        public DVD(string? Director, double Runtime, string? Title, string? Author) : base()
        {
            this.Director = Director;
            this.Runtime = Runtime;
            this.Title = Title;
            this.Author = Author;
        }

        public override void CheckOut()
        {
            AvailabilityStatus = false;
            Console.WriteLine($"This DVD is not availabe...");
        }
    }

 
}