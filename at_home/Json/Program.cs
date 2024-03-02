using System.Reflection.PortableExecutable;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Json
{
    internal class Program
    {
        public class Person
        {
            public string? Name { get; set; }
            public string? Surname { get; set; }
            public bool IsActive { get; set; }
            public int Age { get; set; }
            public List<string>? Friends { get; set; }

        }
        public static void Main()
        {
            string json = File.ReadAllText(@"person.json");
            List<Person> people;

            try
            {
                people = JsonSerializer.Deserialize<List<Person>>(json);
            }
            catch (JsonException ex)
            {
                Console.WriteLine("Error deserializing JSON: " + ex.Message);
                people = new List<Person>();
            }

            Person person = new()
            {
                Name = "Bob",
                Surname = "Bober",
                IsActive = false,
                Age = 15,
                Friends = new List<string> { "Bambina", "Bobana" }
            };

            people.Add(person);
            string updateJson = JsonSerializer.Serialize(person, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("person.json", updateJson);
            Console.WriteLine(updateJson);

            Console.WriteLine("____________________________");

            Person? deserialized = JsonSerializer.Deserialize<Person>(json);
            Console.WriteLine(deserialized.Name);
            Console.WriteLine(deserialized.Surname);
            Console.WriteLine(deserialized.IsActive);
            Console.WriteLine(deserialized.Age);
            foreach (var f in deserialized.Friends)
            {
                Console.WriteLine("Friend: " + f);
            }

            string serialized = JsonSerializer.Serialize(deserialized);
            Console.WriteLine(serialized);
        }


    }
}