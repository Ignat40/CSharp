using System;
using System.Reflection.PortableExecutable;
///<summary>
///Problem: Equality operator
///</summary>
///
/*
            string value1 = "a";
            string vlaue2 = "A";
            Console.WriteLine(value1.Trim().ToLower() ==  vlaue2.Trim().ToLower());


            ///<summary>
            ///Problem: Inequality operator
            ///</summary>
            
            Console.WriteLine("a" != "A");
            Console.WriteLine("a" != "a");
            Console.WriteLine(1 != 2);

            string character = "a";
            Console.WriteLine(character != "A");

            ///<summary>
            ///Problem: Comparison operators
            ///</summary>
            ///
        
            Console.WriteLine(1 < 2);
            Console.WriteLine(1 <= 2);
            Console.WriteLine(1 >= 2);
            Console.WriteLine(1 > 2);


            ///<summary>
            ///Problem: Methods that return Boolean
            ///</summary>

            string test = "The quick brown fox jumpes over the lazy dog.";
            Console.WriteLine(test.Contains("quick"));
            Console.WriteLine(test.Contains("cat"));
            // Using the ! (not operation) forces the code to ensure that the expression is false.
            Console.WriteLine(!test.Contains("The")); //Would be True
            Console.WriteLine(!test.Contains("cadt")); //Would be False

            ///<summary>
            ///Problem: Determine if the 
            ///entered sum is eligable fomr discout
            ///using the "CONDITIONAL OPERATOR  ?:" --> <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
            ///</summary>
            ///

            Console.WriteLine("Enter sum: ");
            int sum = Convert.ToInt32(Console.ReadLine());
            int discount = sum > 1000 ? 100:50;
            Console.WriteLine($"Discount: {discount}");

            //Or it can be embeded direclty into the the conditional operator inline

            Console.WriteLine($"Discount: {(sum > 100 ? 50:10)}");

*/
///<summary>
///Problem: Decision logic challenge
///mplement decision logic based 
///on a series of business rules.
///The business rules specify the access
///that will be granted to users based 
///on their role-based permissions and their career level.
///Code branches will display a different message to the user
///depending on their permissions and level.
///</summer>
///


while (true)
{
    Console.WriteLine("Login with one of the following option:  ");
    Console.WriteLine("1. Enter level: ");
    Console.WriteLine("2. Enter permision: ");

    int selectecOption = 0;
    bool correctInput = int.TryParse(Console.ReadLine(), out selectecOption);
    int flag = 0;

    while (true)
    {
        if (correctInput != true || selectecOption < 1 || selectecOption > 2)
        {
            Console.WriteLine("Wrong input");
            break;
        }
        switch (selectecOption)
        {
            case 1:
                Console.WriteLine("Enter your level: ");
                int level = Convert.ToInt32(Console.ReadLine());
                if (level >= 55)
                {
                    Console.WriteLine("Wlecome, Super Admin user!");
                    flag += 1;
                }        
                else if (level < 55 && level >= 20)
                {   
                    Console.WriteLine("Welcome Admin User!");
                    flag += 1; 
                }
                else if (level < 20 && level >= 10)
                {
                    Console.WriteLine("Contact Admin for access!");
                    flag += 1; 
                }
                else
                {
                    Console.Write("You don't have sufficient privileges.");
                    flag += 1;
                }
                break;

            case 2:
                Console.WriteLine("Enter your privileges wiht lower cases: ");
                string priv = Console.ReadLine();
                if(priv == "super")
                {
                    Console.WriteLine($"Welcome, Super Admin. Level: > 55");
                    flag += 1;
                }
                else if(priv == "admin")
                {
                    Console.WriteLine($"Welcome, Admin. Level: >= 20 < 50");
                    flag += 1;
                }
                else if(priv == "access")
                {
                    Console.WriteLine($"Welcome, Super Admin. Level: >= 10 < 20");
                    flag += 1;
                }
                else
                {
                    Console.WriteLine("You don't have sufficient rights...");
                    flag += 1;
                }
                break;

                
        }

        if(flag == 1)
        {
            return 1;
        }

    }
}
