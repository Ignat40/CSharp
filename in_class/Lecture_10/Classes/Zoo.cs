using System;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;

namespace Zoo
{
    class Animal
    {
        public string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }

        class Lion : Animal
        {
            public Lion(string name) : base(name){}
            public override void MakeSound()
            {
                base.MakeSound();
                Console.WriteLine("Lion Roars");
            }
        }
        
        class Monkey : Animal
        {
            public Monkey(string name) : base(name){}
            public override void MakeSound()
            {
                base.MakeSound();
                Console.WriteLine("Monkey Scerams");
            }
        }
        class Elephant : Animal
        {
            public Elephant(string name) : base(name){}
            public override void MakeSound()
            {
                base.MakeSound();
                Console.WriteLine("Elephant trumpets");
            }
        }
    }
    public class Zoo
    {
        public static void Main()
        {

        }
    }
}