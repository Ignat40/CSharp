namespace Lecture13
{
    public class Program
    {
        public static void Main()
        {
            var studentManager = new StudentManager();
            bool exit = false;
            while(!exit)
            {
                Console.WriteLine("Select an option: ");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View All Studnets");
                Console.WriteLine("3. Search Studnet by Name");
                Console.WriteLine("4. Exit");

                if(!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a valid option");
                }
                switch(choice)
                {
                    case 1:
                        studentManager.AddStudnets();
                        break;
                    case 2:
                        studentManager.ViewAllStudnets();
                        break;
                    case 3:
                        studentManager.Search();
                        break;
                    case 4:
                        
                        break;

                }

            }
        }
    }
}