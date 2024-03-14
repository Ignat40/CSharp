namespace SOLID
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person user)
        {
            Console.WriteLine($"Your user name is: {user.FirstName.Substring(0, 1)}{user.LastName}");
        }
    }
}