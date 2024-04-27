namespace LINQ;
using System.Globalization;

public class Program
{
    public static void Main()
    {
        var students = new[]
        {
            new Studnet("Ivan", "Petrov", 19),
            new Studnet("Ivelin", "Nedqlkov", 16),
            new Studnet("Elena", "Bojinova", 21),
            new Studnet("Georgi", "Iskariotski", 15),
            new Studnet("Vladi", "Uzunov", 14),
            new Studnet("Bobi", "Buchwata", 25),
        };

        var studentsOrdered = Studnet.Order(students);

        foreach (var student in studentsOrdered)
        {
            Console.WriteLine($"Name: {student.FirstName} {student.LastName}, Age: {student.Age}");
        }

        double[] numbers = [21, 3, 5, 1234, 1293, 827, 9827, 92837, 63, 21.42];

        var ordered =
            from number in numbers
            where number % 3 == 0 && number % 7 == 0
            select number;

        var ord = numbers.Where(number => number % 3 == 0 && number % 7 == 0);

        foreach (var o in ord) //ordered 
        {
            Console.WriteLine(o);
        }

        string samppleSentance = "this iS Sample sentance";

        Console.WriteLine(StringExtentions.Capitalize(samppleSentance));



        
        CultureInfo customCulture = new CultureInfo("en-GB");
        CultureInfo.DefaultThreadCurrentCulture = customCulture;
        CultureInfo.DefaultThreadCurrentUICulture = customCulture;

        DateTime someDate = DateTime.Parse("13/07/2023 00:00");
        Console.WriteLine(someDate.ToString());

    }
}