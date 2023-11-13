using System.Collections;

class Program
{
    public static void Main()
    {
        ///Array 
        int[] nums = new[]{2,3,4};
        ///List
        List<int> number = new() { 2, 3, 4, 5 };
        Console.WriteLine(number.Count);
        number.Add(6);
        number.Remove(4);
        ///Array List -> it can hold many types
        ArrayList test = new(){2, "3", 5, "word"};

        ///Queue
        ///FIFO Queue, FILO, LILO, LIFO
        ///First-in-first-out, First-in-last-out, Last-in-last-out
        ///Ideal for scenarios like  task scheduling, 
        ///when you want items in the order they were added 
        Queue<double> prices = new();
        prices.Enqueue(9.99);
        double firstAdded = prices.Dequeue();
        ///Stack -> , Last-in-last-out(STACK)
        ///Fast operations for the use-case when you only need the last item inserted. 
        Stack<string> books = new();
        books.Push("Book1");
        books.Push("Book2");
        books.Peek();
        string lastAdded = books.Pop();
        ///Dictionaries
        ///Collection of key Key/Value pairs.
        Dictionary<string, int> ages = new()
        {
            {"Alice", 30},
            {"Bob", 35},
        };
        ages["Harold"] = 40; 
        ages.Add("Derek", 40);

        foreach(var kvPair in ages)
        {
            Console.WriteLine($"{kvPair.Key} is {kvPair.Value} years old");
        }
        
        ///Hashset
        ///Using for storing unique elements and performs fast lookups
        ///Excellent performance for lookups, adding and removing.
        ///Ensures no duplicates.
        ///It does not preserve the order of the elements. 
        HashSet<int> uniqueNumber = new() {2, 3, 4, 5};
        uniqueNumber.Add(3); // Will not be added as it's already there.
        uniqueNumber.Add(6); // Will be added 

    }
}