using System;
using System.Globalization;
using System.Xml.Serialization;

namespace RPS
{
    class Program
    {
        public static void Main()
        {
            
            string[] choice = {"Rock", "Paper", "Scissors"};
            Random random = new Random();
            
            int computerScore = 0;
            int yourScore = 0; 
            bool isWon = false;

            Console.WriteLine("Rock, Paper, Scissors against the machine! \nBest out of three wins!\n");

            while(!isWon)
            {
                int randomIndex = random.Next(0, choice.Length);
                string randomString = choice[randomIndex];
                Console.WriteLine("Choose: \n1. Rock \n2. Paper \n3. Scissors");
                string input = Console.ReadLine();

                if(input == "1")
                {
                    Console.WriteLine($"You: Rock \tBot: {randomString} \n");

                    if(randomString == "Rock")
                        continue;
                    else if(randomString == "Paper")
                    {
                        Console.WriteLine($"Score: {yourScore += 1} - {computerScore}\n");
                    }
                    else if(randomString == "Scissors")
                    {
                        Console.WriteLine($"Score: {yourScore} - {computerScore += 1}\n");
                    }
                }
                else if(input == "2")
                {
                    Console.WriteLine($"You: Paper \tBot: {randomString} \n");

                    if(randomString == "Paper")
                        continue;
                    else if(randomString == "Rock")
                    {
                        Console.WriteLine($"Score: {yourScore += 1} - {computerScore}\n");
                    }
                    else if(randomString == "Scissors")
                    {
                        Console.WriteLine($"Score: {yourScore} - {computerScore += 1}\n");
                    }
                }
                else if(input == "3")
                {
                    Console.WriteLine($"You: Scissors \tBot: {randomString} \n");

                    if(randomString == "Scissors")
                        continue;
                    else if(randomString == "Paper")
                    {
                        Console.WriteLine($"Score: {yourScore += 1} - {computerScore}\n");
                    }
                    else if(randomString == "Rock")
                    {
                        Console.WriteLine($"Score: {yourScore} - {computerScore += 1}\n");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input... Try again: \n ");
                }

                if(yourScore == 3)
                {
                    Console.WriteLine("YOU WIN!");
                    isWon = true;
                }
                else if(computerScore == 3)
                {
                    Console.WriteLine("You lose...");
                    isWon = true;
                }
                
            }


        }
    }
}