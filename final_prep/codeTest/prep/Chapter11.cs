using Microsoft.VisualBasic;
using System.Collections;

namespace FinalPrep
{
    class Chapter11
    {
        public static void ListExercise()
        {
            List<string> favBooks = new List<string> { "book1", "book2", "book3", "book4" };
            foreach (var b in favBooks)
            {
                Console.Write(b + ", ");
            }
            favBooks.Add("book6");
            favBooks.Add("book7");
            favBooks.Add("book8");
            favBooks.Remove("book1");
            Console.WriteLine("");
            foreach (var b in favBooks)
            {
                Console.Write(b + ", ");
            }

        }

        public static void DictionaryExercise()
        {
            Dictionary<string, int> countryPopulation = new Dictionary<string, int>();
            countryPopulation.Add("Bulgaria", 7000000);
            countryPopulation.Add("Denmark", 6000000);
            countryPopulation.Add("Poland", 14000000);

            foreach (var pair in countryPopulation)
            {
                Console.WriteLine(pair);
            }

        }

        public static void QueueExercises()
        {
            Queue<string> peopleOnBus = new Queue<string>();
            peopleOnBus.Enqueue("Person1");
            peopleOnBus.Enqueue("Person2");
            peopleOnBus.Enqueue("Person3");
            peopleOnBus.Enqueue("Person4");
            peopleOnBus.Enqueue("Person5");

            peopleOnBus.Dequeue();
            peopleOnBus.Dequeue();
            peopleOnBus.Dequeue();

            peopleOnBus.Enqueue("Karolina");
            peopleOnBus.Enqueue("Utopia");
            peopleOnBus.Enqueue("Rosco");

            while (peopleOnBus.Count > 0)
            {
                string person = peopleOnBus.Dequeue();
                Console.WriteLine($"Person {person} f'ed off of the bus");
            }
        }

        public static void StackExercise() //last in first out
        {
            Stack plates = new Stack();

            plates.Push("plate 1");
            plates.Push("plate 2");
            plates.Push("plate 3");
            plates.Push("plate 4");
            plates.Push("plate 5");

            plates.Pop();

            foreach (var p in plates)
            {
                Console.WriteLine(p);
            }
        }

        public static void HashEx()
        {
            HashSet<string> myhash1 = new HashSet<string>();

            myhash1.Add("C");
            myhash1.Add("C++");
            myhash1.Add("C#");
            myhash1.Add("Java");
            myhash1.Add("Ruby");
            Console.WriteLine("Elements of myhash1:");
            
            foreach (var val in myhash1)
            {
                Console.WriteLine(val);
            }
        }
    }
}