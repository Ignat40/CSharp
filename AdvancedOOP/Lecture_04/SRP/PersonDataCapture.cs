namespace SOLID
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            Person output = new();

            Console.Write("What is your First Name: ");
            output.FirstName = Console.ReadLine();

            Console.Write("What is your Last Name: ");
            output.LastName = Console.ReadLine();

            return output;
        }
    }
}