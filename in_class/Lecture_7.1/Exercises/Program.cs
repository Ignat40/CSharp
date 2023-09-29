namespace Kotseto
{
    class Program
    {

        enum FoodType
        {
            Dairy,
            Meat,
            Fruit,
            Vegatable,
            Beveage
        }

        struct FoodItem
        {
            public string Name;
            public FoodType Type;
            public int Quantity;
            public string ExpirationDate;
        }

        public static void Main()
        {
            //SmartFridge();
            Console.WriteLine("Signed integral types:");

            Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");
            Console.WriteLine("Signed integral types:");

            Console.WriteLine("");
            Console.WriteLine("Unsigned integral types:");

            Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

            Console.WriteLine("");
            Console.WriteLine("Floating point types:");
            Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
            Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
            Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
        }

        public static void SmartFridge()
        {
            //Keep up with items in the firdge
            //Their quantity, their expiration dates.

            FoodItem[] fridgeItems = new FoodItem[]
            {
              new FoodItem{Name = "Milk", Type = FoodType.Dairy,
              Quantity = 1, ExpirationDate = "2023-10-3"},
              new FoodItem{Name = "Chicken", Type = FoodType.Meat,
              Quantity = 2, ExpirationDate = "2023-10-15"},
              new FoodItem{Name = "Carrot", Type = FoodType.Vegatable,
              Quantity = 5, ExpirationDate = "2023-10-15"}
            };

            while (true)
            {
                Console.WriteLine("Smart Fridge Management\n");
                Console.WriteLine("1. View Item");
                Console.WriteLine("2. Add Item");
                Console.WriteLine("3. Update Item");
                Console.WriteLine("4. Exit");

                string? choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("Friddge Items \n-----------------\n");
                    for (int i = 0; i < fridgeItems.Length; i++)
                    {
                        Console.WriteLine($"Item {i + 1}: ");
                        Console.WriteLine($"Name: {fridgeItems[i].Name}");
                        Console.WriteLine($"Type: {fridgeItems[i].Type}");
                        Console.WriteLine($"Quantity: {fridgeItems[i].Quantity}");
                        Console.WriteLine($"ExpirationDate: {fridgeItems[i].ExpirationDate}\n");
                    }
                }

                else if (choice == "2")
                {
                    Console.WriteLine("Enter food name: ");
                    string? name = Console.ReadLine();
                    Console.WriteLine("Enter food type[Enter Index]: ");
                    if (int.TryParse(Console.ReadLine(), out int typeInt))
                    {
                        FoodType type = (FoodType)typeInt;
                        Console.WriteLine("Enter Quantity: ");
                        if (int.TryParse(Console.ReadLine(), out int quantity))
                        {
                            Console.WriteLine("Enter date of expiration (YYYY-MM-DD)");
                            string? expiryDate = Console.ReadLine();

                            Array.Resize(ref fridgeItems, fridgeItems.Length + 1);
                            fridgeItems[^1] = new FoodItem
                            {
                                Name = name,
                                Type = type,
                                Quantity = quantity,
                                ExpirationDate = expiryDate
                            };
                        }
                        else
                        {
                            Console.WriteLine("Invalid Quantity. Try again.");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid food type. Try again. ");
                    }
                }

                else if (choice == "3")
                {
                    Console.WriteLine("Select item to update quantity. [Enter index]");
                    for (int i = 0; i < fridgeItems.Length; i++)
                    {
                        Console.WriteLine($"{i} : {fridgeItems[i].Name}");
                    }

                    if (int.TryParse(Console.ReadLine(), out int index))
                    {
                        Console.WriteLine("Enter new quantity");
                        if (int.TryParse(Console.ReadLine(), out int newQuantity))
                        {
                            fridgeItems[index].Quantity = newQuantity;
                            Console.WriteLine("Quantity Updated");
                        }
                        else
                        {
                            Console.WriteLine("Invalid quontity. Try again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid index. Try again. ");
                    }


                }

                else if (choice == "4")
                {
                    Console.WriteLine("Thank you for using the Smart Fridge!");
                    break;
                }

            }


        }
    }
}