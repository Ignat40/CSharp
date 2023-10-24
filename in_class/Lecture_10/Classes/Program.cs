using System;

namespace Classes
{
    public interface IFlyAble
    {
        void Fly();
        void Land();
    }
    public class Bird : IFlyAble
    {
        public string Species { get; set; }

        public Bird(string species)
        {
            Species = species;
        }
        public void Fly()
        {
            Console.WriteLine($"{Species} is flying high!");
        }
        public void Land()
        {
            Console.WriteLine($"{Species} has landed safetly");
        }
    }
    public class Airplane : IFlyAble
    {
        public string Model { get; set; }

        public Airplane(string model)
        {
            Model = model;
        }
        public void Fly()
        {
            Console.WriteLine($"Airplane {Model} is in the air.");
        }

        public void Land()
        {
            Console.WriteLine($"Airplane {Model} has landed.");
        }
    }

    public class SuperMan : IFlyAble
    {
        public string SuperHero {get; set;}
        public SuperMan(string superHero)
        {
            SuperHero = superHero;
        }
        public void Fly()
        {
            Console.WriteLine($"Superman {SuperHero} is comming to save your ass");
        }
        public void Land()
        {
            Console.WriteLine($"Superman {SuperHero} is rresting.");
        }
    }
}