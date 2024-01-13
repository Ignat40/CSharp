namespace FinalPrep
{
    class Chapter2
    {
        // Write a program to calculate the area of a circle. 
        // Prompt the user for the radius and display the result. 
        // Use a function to perform the calculation.
        public static double AreaCalc()
        {
            Console.WriteLine("Enter value for the radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * radius * radius;
            return area;
        }

        // Create a program that compares two numbers entered by the user
        // and prints whether they are equal, greater than, or less than each other.
        public static void Comparinator()
        {
            Console.WriteLine("Enter value for num1: ");
            int num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter value for num2: ");
            int num2 = Convert.ToInt16(Console.ReadLine());

            if(num1 < num2)
                Console.WriteLine($"{num1} is less than {num2}");
            else if(num1 > num2)
                Console.WriteLine($"{num1} is greater than {num2}");
            else    
                Console.WriteLine($"{num1} is equal to {num2}");
               
        }
    }

}