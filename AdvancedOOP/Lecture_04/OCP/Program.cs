namespace SOLID;
public class OCP // Open-Close Principle -> should be closed for extetion but open for modification. (refer to Accounts class)
{
    public static void Main()
    {
        List<IPersonModel> applicants =
        [
            new PersonModel { FirstName = "Tim", LastName = "Cook"},
            new PersonModel { FirstName = "Elon", LastName = "Musk"},
            new PersonModel { FirstName = "Jeff", LastName = "Bezos"},
        ];

        List<EmployeeModel> employees = [];
        Accounts accountProcessor = new();

        foreach(var person in applicants)
        {
            employees.Add(person.AccountProcessor.Create(person));
        }

        foreach(var emp in employees)
        {
            Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAdress}, Is Manager: {emp.IsManager}" );
        }

    }
}
