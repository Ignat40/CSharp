namespace SOLID
{
    public class StandartMessages
    {
        public static void SayWelcomeMessage()
        {
            Console.WriteLine("Welcome to my application!");
        }

        public static void EndApplication()
        {
            Console.ReadLine();
        }

        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"You did not give a valid { fieldName }!");
        }
    }
}
