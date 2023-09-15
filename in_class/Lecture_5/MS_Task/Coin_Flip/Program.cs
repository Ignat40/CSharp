using System;

namespace MS_Task
{
    class Program
    {
        static void Main()
        {
            
            //<summery>
            //Problem: Write a program that simulates 
            // a flipping a coin. But do it by using 
            // the conditional operator. 
            //</summery>
            
            Random coinToss = new Random();
            int flip = coinToss.Next(1,3);
            Console.WriteLine($"It's: {(flip == 1 ? "Heads":"Tails")}");
        }
    }
}