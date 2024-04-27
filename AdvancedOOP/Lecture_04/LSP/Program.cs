using System.Buffers;

namespace SOLID;

public class Program
{

    // LSP -> obejects of a superclass should be replaceable
    // with objects of its subclass without affecting the corrections
    // of the pogram. 

    public static void Main()
    {
        Manager accountingVP = new()
        {
            FirstName = "Emma",
            LastName = "Stone"
        };
        accountingVP.CalculatePerHourRate(4);

        BaseEmployee emp = new CEO()
        {
            FirstName = "Tim",
            LastName = "Tim",
        };

        //emp.AssignManager(accountingVP);
        emp.CalculatePerHourRate(2);


        Console.WriteLine($"{emp.FirstName}'s salary is {emp.Salary}/hour");
        Console.ReadLine();


    }
}