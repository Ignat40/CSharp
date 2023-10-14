using System;
using System.Collections.Generic;

namespace GuessTheNumberGame
{
    enum Difficulty
    {
        Easy = 10,
        Medium = 20,
        Hard = 50
    }

    struct GameScore
    {
        public int TotalGuesses;
        public int CorrectGuesses;
    }

    class Review5
    {
        static void Main()
        {
            GameScore score = new() { TotalGuesses = 0, CorrectGuesses = 0 };

             

            while (true)
            {
                Console.WriteLine("Select difficulty: Easy, Medium, Hard or Exit to quit.");
                string? input = Console.ReadLine();
                if (input?.ToLower() == "exit") break;

                if (Enum.TryParse(input, true, out Difficulty difficulty))
                {
                    if(Enum.IsDefined(typeof(Difficulty), (int)(difficulty)))
                    {
                        StartNewRound(ref score, difficulty);
                    }
                }
            }
        }

        static void StartNewRound(ref GameScore score, Difficulty difficulty)
        {
            int targetNumber = GenerateRandomNumber(difficulty);
            while (true)
            {
                Console.WriteLine($"Guess the number between 1 and {(int)difficulty} or Exit to exit.");
                string? guessInput = Console.ReadLine();
                if (guessInput?.ToLower() == "exit") Environment.Exit(0);
                if (int.TryParse(guessInput, out int guess))
                {
                    if (EvaluateGuess(targetNumber, guess, ref score))
                    {
                        Console.WriteLine("You guessed it!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }
        }

        static int GenerateRandomNumber(Difficulty difficulty)
        {
            Random random = new();
            return random.Next(1, (int)difficulty + 1);
        }

        static bool EvaluateGuess(int target, int guess, ref GameScore score)
        {
            bool isCorrect = target == guess;
            score.TotalGuesses++;


            if (isCorrect)
            {
                score.CorrectGuesses++;
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine(target > guess ? "Too low!" : "Too high!");
            }

            Console.WriteLine($"Your score: {score.CorrectGuesses} / {score.TotalGuesses}");

            return isCorrect;
        }
    }
}
