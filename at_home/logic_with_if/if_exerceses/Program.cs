using System;
using System.Xml.Schema;

namespace Learning_IF
{
    class Program
    {
        static void Main()
        {
            ///<summery>
            ///Probelm: Three Rolling Dice!
            ///Create a program that rolls 
            ///three random die. If any two dice
            ///you roll result in the same value, 
            ///you get two bonus points for rolling doubles.
            ///If all three dice you roll result in the same value, 
            ///you get six bonus points for rolling triples.
            ///If the sum of the three dice rolls,
            ///plus any point bonuses, is 15 or greater, 
            ///you win the game. Otherwise, you lose.
            ///</summer>
            
            
            Random dice = new Random();
            int roll_1 = dice.Next(1,7);
            int roll_2 = dice.Next(1,7);
            int roll_3 = dice.Next(1,7);

            int sum = roll_1 + roll_2 + roll_3;
            Console.WriteLine($"The sum of {roll_1} + {roll_2} + {roll_3} is: {sum}");

            
            if(roll_1 == roll_2 || roll_1 == roll_3 || roll_2 == roll_3)
            {
                 if((roll_1 == roll_2) && (roll_2 == roll_3))
                {
                    sum += 6;
                    Console.WriteLine($"Your score is: {sum} + 6 extra points");
                }
                else
                {
                    sum += 2;
                    Console.WriteLine($"Your score is: {sum} + 2 extra points");
                }
                
            }
            if(sum >= 15)
                Console.WriteLine("Congratulations, YOU WIN!");
            else if(sum >= 16)
                Console.WriteLine("MY GOD YOU WIN A CAR!");
            else if(sum >= 10)
                Console.WriteLine("Nice job, you win a gum.");
            else    
                Console.WriteLine("Sorry, You Lose...");
            

            ///<summary>
            ///Exercise: Improve renewal rate of subscriptions
            ///f the user's subscription will expire in 10 days or less,
            ///display the message: Your subscription will expire soon. Renew now!
            ///If the user's subscription will expire in five days or less, 
            ///display the messages: Your subscription expires in _ days.Renew now and save 10%!
            ///If the user's subscription will expire in one day, 
            ///display the messages: Your subscription expires within a day! Renew now and save 20
            ///If the user's subscription has expired, 
            ///display the message: Your subscription has expired.
            ///If the user's subscription doesn't expire in 10 days or less, display nothing.
            ///</summery>

            Random day = new Random();
            int daysUntilExpiration = day.Next(-10, 12);
            int discountPercentage = 0;


            if(daysUntilExpiration <= 10 && daysUntilExpiration >= 5)
                Console.WriteLine($"Your subscription will expire in {daysUntilExpiration}. Renew now!");
            else if (daysUntilExpiration <= 5 && daysUntilExpiration >=1)
            {
                discountPercentage += 10;
                Console.WriteLine($"Your subscription will expire in {daysUntilExpiration}. Renew now and get {discountPercentage}%!");
            }
            else if (daysUntilExpiration <= 1 && daysUntilExpiration > 0)
            {
                discountPercentage += 20;
                Console.WriteLine($"Your subscription will expire in {daysUntilExpiration}. Renew now and get {discountPercentage}%!");
            }
            else if (daysUntilExpiration >= -2 && daysUntilExpiration == 0)
                Console.WriteLine("Your subsciption has expired. Please renew...");
            else
                Console.WriteLine("-");
                

        }
    }
}