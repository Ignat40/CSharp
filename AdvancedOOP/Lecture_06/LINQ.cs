using System.Collections.Immutable;
using System.Net;
using System.Xml.Schema;

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

    public static IEnumerable<string> FilterAndSort(IEnumerable<string> inValues, string pattern)
    {
        return from value in inValues
               where value.Contains(pattern)
               orderby value
               select value;

    }


    // Method syntax 

    static List<string> longAndShortBoyNames = new List<string>
        {"Jack", "Alexander", "Ivan", "Timothey", "Kacper", "Levi", "Franchesco"};

    public IEnumerable<string> longBoyNames =
        longAndShortBoyNames
        .Where(name => name.Length >= 5)
        .OrderBy(name => name.Length);


    // Method to Extract Single Element
    // .First()

    static List<double> doubles = [2.0, 2.1, 2.2, 2.3, 2.4];
    public double firstOfList = doubles.First();

    // .Last()
    public double lastOfList = doubles.Last();

    // .ElementAt()
    public double elementAtIndex3 = doubles.ElementAt(3);

    // .Single() -> throws an exception if there are more than one elements. 
    //public double singleCheck = doubles.Single();


    // Methods - Conditionally Extract a single element 
    //public double whatsThis = doubles.First(val => val > 2.5);
    //public double whatIsThis = doubles.Last(val => val < 2.3);
    //double whatTfIsThis = doubles.Single(val => val > 2.2);


    // Methods - Extract a single element or default

    // .FirstOrDefault()
    public double firstOrDefault = doubles.FirstOrDefault(val => val > 2.4);

    // .LastOrDefault
    public double lastOrDefault = doubles.LastOrDefault(val => val > 2.0 && val < 2.3);

    // .ElementAtOrDefault()
    public double atOrDefault = doubles.ElementAtOrDefault(5);

    // .SingleOrDefault()
    //public double singleOrDefault = doubles.SingleOrDefault(val => val > 2.2 && val <= 2.4);


    // Methods to exrtact Multiple Elements

    public static List<bool> bools = [true, false, true, true, false];

    // .Take() -> method extracts the first n elements (where n is a parameter to the method) 
    // from the beginning of the target sequence and returns a new sequence containing only the elements taken.
    public IEnumerable<bool> results = bools.Take(3);

    // .Skip() -> "skips" over the first n elements in the sequence 
    // and returns a new sequence containing the remaining elements after the first n elements.
    public IEnumerable<bool> results2 = bools.Skip(2);


    static List<int> ints = [1, 2, 4, 5, 4, 2, 1];
    // .TakeWhile() -> "takes" all of the initial elements of a sequence that meet the criteria
    //  specified by the predicate, and stops on the first element that doesn't meet the criteria
    public IEnumerable<int> results3 = ints.TakeWhile(theInt => theInt < 5);

    // .SkipWhile() ->  "skips" the initial elements of a sequence that meet the criteria
    // specified by the predicate and returns a new sequence containing the first element that doesn't meet the criteria as well as any elements that follow.
    public IEnumerable<int> results4 = ints.TakeWhile(theInt => theInt != 4);


    public static IEnumerable<string> GetStartThroughEnd(IEnumerable<string> words)
    {
        return words.TakeWhile(word => word != "start").SkipWhile(word => word != "end");
    }


}