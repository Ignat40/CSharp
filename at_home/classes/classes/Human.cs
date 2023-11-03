namespace ClassesExercises
{
    class Human
    {
        public string? Name;
        public int Age;
        public bool IsAdult;

        public void HumanInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            if(Age >= 18)
            {
                IsAdult = true;
                Console.WriteLine($"Adult: Yes");
            }
            else
                Console.WriteLine($"Adult: No");
        }
        public void Greeting()
        {
            Console.WriteLine($"Hello, {Name}");
        }
        public void Birthday()
        {
            Age++;
            Console.WriteLine($"Happy {Age}th b-day!");
        }
    }

}