using System.Net;

namespace Lecture_06;

// LINQ is a libary used to execute queries directly in C# syntax
// Set of extention of the IEnumerable<T>
// LINQ != SQL, it's not a database access API 


public class LINQ
{

    // Lambda Expressions 
    // Defining an anonymous funciton that can be 
    // passed around as a variable or as a parameter to a method call. 

    public static Func<int, int> multiplyByFive = num => num * 5;
    public static Func<double, double> increaseByOne = num => num + 1;

    // IEnumerable<T> - interface that guarantees a given class is iterable. 
    // Most collections and all arrays implement the interface 
    // <T> means that the interface is generic, meaning it can be used by any datatype

    // LINQ provides ToList() and ToArray() as 
    // a ny LINQ method that returns a sequence of elements returns it as an

    static List<string> animalNames = new List<string>
        {"rex", "sharo", "iro", "max", "benadiktas", "oliver"};

    public IEnumerable<string> longAnimalNames = 
        from name in animalNames
        where name.Length >= 4
        orderby name.Length
        select name;
}