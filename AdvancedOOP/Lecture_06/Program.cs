namespace Lecture_06;

public class Program
{
    public static void Main()
    {
        // Lambda functions 
        // LINQ test = new();
        // Console.WriteLine(LINQ.multiplyByFive(7));
        // Console.WriteLine(LINQ.increaseByOne(7));

        // foreach (var l in test.results4)
        // {
        //     Console.WriteLine(l);
        // }

        // Console.WriteLine(test.firstOfList);
        // Console.WriteLine(test.lastOfList);
        // Console.WriteLine(test.elementAtIndex3);
        // Console.WriteLine(test.singleCheck);

        IEnumerable<string> words = new List<string> { "apple", "banana", "start", "orange", "end", "grape", "a", "b", "herher", "herself"};

        IEnumerable<string> result = LINQ.GetStartToEnd(words);

        foreach (string word in result)
        {
            Console.WriteLine(word);
        }

        // Console.WriteLine(LINQ.GetFirstSingleLetterWord(words));
        // Console.WriteLine(LINQ.GetLastWordWithHerInIt(words));
        // Console.WriteLine(LINQ.GetFifthWordIfEists(words));
        // Console.WriteLine(LINQ.GetLastWordIfAny(words));
        


    }
}