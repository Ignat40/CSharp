namespace SOLID;

public class ExecutiveAccounts : IAccounts
{

    public EmployeeModel Create(IPersonModel person)
    {
        EmployeeModel output = new();

        output.FirstName = person.FirstName;
        output.LastName = person.LastName;
        output.EmailAdress = $"{person.FirstName}.{person.LastName}@acmecorp.com";

        output.IsManager = true;
        output.IsExecutive = true; 

        return output;
    }

}