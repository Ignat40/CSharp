using System.Security.Cryptography;

namespace LINQ;

/// <summary> 
///Write a class Student with the following properties: first name, last name
///and age. Write a method that for a given array of students finds those,
///whose first name is before their last one in alphabetical order. Use LINQ.
/// </summary>

public class Studnet(string? firstName, string? lastName, int age)
{
    public string? FirstName { get; set; } = firstName;
    public string? LastName { get; set; } = lastName;
    public int Age { get; set; } = age;


    public static IEnumerable<Studnet> FirstNameBeforeLastName(IEnumerable<Studnet> students)
    {
        return students.Where(stud => string.Compare(stud.FirstName, stud.LastName) < 0);
    } 

    public static IEnumerable<Studnet> FindAgeGap(IEnumerable<Studnet> studnets)
    {
        return studnets.Where(student => student.Age >= 18 && student.Age <= 25);
    }

    public static IEnumerable<Studnet> Order(IEnumerable<Studnet> studnets)
    {
        return studnets.OrderByDescending(student => student.LastName).ThenByDescending(studnet => studnet.FirstName);
    }
}
