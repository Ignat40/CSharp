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
