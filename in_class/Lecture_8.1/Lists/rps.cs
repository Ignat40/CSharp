using System;

namespace RPS
{

    enum Choice{Rock, Paper, scissors}
    class Prog
    {
        static int playerWins = 0;
        static int conputerWins = 0;
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors");
            Console.WriteLine("Enter your name: ");
            string? playerName = Console.ReadLine();

            while(true)
            {
                Console.WriteLine($"{playerName}, choose your weapon");

                string? choiceString = Console.ReadLine();

                if(!Enum.TryParse(choiceString, true, out Choice playerChoice))
                {
                    Console.WriteLine("Invalid choice. Try Again: \n");
                    continue;
                }            

                Choice computerChoice = (Choice) new Random().Next(0, 3);
                Console.WriteLine($"Computer choice: {computerChoice}");

            }
        }
    }

    static void DetermineWinner(Choice player, Choice computer)
    {   
        if(player == computer)
        {
            Console.WriteLine("It's a tie!");
            return;
        }

        if(
            (player == Choice.Rock && computer == Choice.scissors) ||
            (player == Choice.Paper && computer == Choice.Rock) ||
            (player == Choice.Paper && computer == Choice.Rock)
        )
        {
         Console.WriteLine("You Win!");
         return;   
        }

        DetermineWinner("Computer wins, you lose...");
    }

}