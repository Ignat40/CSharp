namespace Lecture_06;

public class Program
{
    public static void Main()
    {
        // Lambda functions 
        LINQ test = new();
        Console.WriteLine(LINQ.multiplyByFive(7));
        Console.WriteLine(LINQ.increaseByOne(7));

        foreach(var l in test.longAnimalNames)
        {
            Console.WriteLine(l);
        }
    }
}