using DemoLibrary.Modles;

namespace DemoLibrary
{
    public static class DataAccess
    {
        private static string personTextFIle = "PersonText.txt";
        public static void AddNewPerson(PersonModel person)
        {
            List<PersonModel> people = GetAllPeople();
            
            AddPersonToPeopleList(people, person);

            List<string> lines = ConvertModelsToCSV(people);
            
            File.WriteAllLines(personTextFIle, lines);
        }

        public static void AddPersonToPeopleList(List<PersonModel> people, PersonModel person)
        {
            if(string.IsNullOrWhiteSpace(person.FirstName))
                throw new ArgumentException("You passed in an invalid parameter", "First Name");
            if(string.IsNullOrWhiteSpace(person.LastName))
                throw new ArgumentException("You passed in an invalid parameter", "Last Name");
                
            people.Add(person);
        }

        public static List<string> ConvertModelsToCSV(List<PersonModel> people)
        {
            List<string> output = new List<string>();

            foreach (PersonModel user in people)
            {
                output.Add($"{user.FirstName},{user.LastName}");
            }

            return output;
        }

        public static List<PersonModel> GetAllPeople()
        {
            List<PersonModel> output = new List<PersonModel>();
            string[] content = File.ReadAllLines(personTextFIle);

            foreach (string line in content)
            {
                string[] data = line.Split(',');
                output.Add(new PersonModel { FirstName = data[0], LastName = data[1] });
                Console.WriteLine(line);
            }

            return output;
        }
    }
}