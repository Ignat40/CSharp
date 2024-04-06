namespace SOLID
{
    public class Accounts : IAccounts//If it works don't change it. Just add the needed extra functionality.
    {
        public EmployeeModel Create(IPersonModel person)
        {
            EmployeeModel output = new();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAdress = $"{person.FirstName[..1]}{person.LastName}@acme.com";

            return output;
        }
    }
}