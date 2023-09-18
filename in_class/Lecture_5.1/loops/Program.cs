using System;

namespace Name
{
    class Program
    {
        static void Main()
        {
            //--------------------- DO WHILE LOOPS ---------------------------------------------------------------------------------

            //The code block is being executed until the boolean test
            //equals to False

            //Ex. 1

            int n = 1;
            
            do
            {
                Console.WriteLine($"{n++}");
            } while(n <= 10);


            // Calculate the balance over 10 years

            double balance, interestRate, targetBalance;
            Console.WriteLine("Enter current balance: ");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter annual interest rate in %: ");
            interestRate = 1 + Convert.ToDouble(Console.ReadLine()) / 100.0;
            Console.WriteLine("What balance would you like to have: ");
            targetBalance = Convert.ToDouble(Console.ReadLine());
            int totalYears = 0;

            do
            {
                balance *= interestRate;
                totalYears++;
            } while(balance < targetBalance);

            Console.WriteLine($"In {totalYears} year{(totalYears == 1 ? "": "s")}" +
                $" you will have a balance of {balance}.");

            //--------------------- WHILE LOOPS ---------------------------------------------------------------------------------

            //The difference here is that the 
            //Boolean test takes place in the begining.
            //Thus the cycle never starts if the test evaluates to false. 

            //Ex. 2 
    
            //We use the variable from line 16.

            while (n <= 10)
            {
                Console.WriteLine($"{n++}");
            }

            // Calculate the balance over 10 years - using  the same variables

            while (balance < targetBalance)
            {
                balance *= interestRate; ++totalYears;
            }
            Console.WriteLine($"In {totalYears} year{(totalYears == 1 ? "" : "s")} " +
            $"you'll have a balance of {balance}.");
            if (totalYears == 0) Console.WriteLine(
            "To be honest, you really didn't need to use this calculator.");
            Console.ReadKey();

            //--------------------- FOR LOOPS ---------------------------------------------------------------------------------

            //Executes a set of number of times
            //and maintains its own counter. 
            //To be defined you need: 
            // 1. Starting value to initialize the counte variable
            // 2. Condition for continuing the loop, involving the counter var.
            // 3. Operation to perform on the counter variable at the end of each loop cycle. 

            //Ex. 3 

            for (int a = 1; a <= 10; a++)
            {
                Console.WriteLine(a);
            }

            //--------------------- INTERRUPTING LOOPS ---------------------------------------------------------------------------------

            // break - Causes the loop to end immediately
            // continue - Causes the current loop cycle to end immediately
            //            Execution will continue with the next loop.
            // brealk - Jumpes out of the loop and its containing function.

            // Ex. 4 - break;

            while (n <= 10)
            {
                if (n == 6)
                    break;
                Console.WriteLine($"{n++}");
            }

            for (int b = 1; b <= 10; b++)
            {
                if (b % 2 != 0) 
                    continue;
                Console.WriteLine(b);
            }


            // Exercise 1. 

            int var1, var2; 
            

            while(true)
            {
                Console.WriteLine("Enter two integers");
                var1 = Convert.ToInt32(Console.ReadLine());
                var2 = Convert.ToInt32(Console.ReadLine());

                if(var1 >= 10 && var2 >= 10)
                {
                    Console.WriteLine("Both of the ints can't be grater than 10!");
                    Console.WriteLine("Enter two new numbers: ");
                    continue;
                }
                
                Console.WriteLine($"{var1} is {(var1 >= 10 ? ">" : "<")} than 10");
                Console.WriteLine($"{var2} is {(var2 >= 10 ? ">" : "<")} than 10");

                break;
            }



            // Exercise 2. - Fix the Code.

            int i;
            for (i = 1; i <= 10; i++)
            {
                if  (i % 2 == 0) 
                    continue;
                Console.WriteLine(i);
            }


        }

    }
}
