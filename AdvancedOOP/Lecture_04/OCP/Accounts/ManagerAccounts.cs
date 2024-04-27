namespace SOLID;

public class ManagerAccounts : IAccounts
{
    public EmployeeModel Create(IPersonModel person)
    {
        EmployeeModel output = new();

        output.FirstName = person.FirstName;
        output.LastName = person.LastName;
        output.EmailAdress = $"{person.FirstName[..1]}{person.LastName}@acmecorp.com";

        output.IsManager = true;

        return output;
    }
}