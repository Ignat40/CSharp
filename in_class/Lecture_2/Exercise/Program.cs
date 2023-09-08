/* Random dice = new Random(); // Creates a new instance of the Random class to create a new object called dice. 
int roll = dice.Next(1, 7);
Console.WriteLine("It's: " + roll); 


//-----Overloading methods using the example from above-----


Random ddice = new Random();
int roll1 = ddice.Next();
int roll2 = ddice.Next(101);
int roll3 = ddice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}"); 


//----- CODING EXERCISE - Implement a method of the Math class that returns the larger of two numbers -----

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue); */

//----- CODING EXERCISE - Write a program that lets you input your name, two numbers and outputs their sum and difference -----

Console.WriteLine("Hello, what's your name: ");
string name = Console.ReadLine();
Console.WriteLine($"Hello, {name}, now give me two numbers:");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int sum = num1 + num2;
int difference = num1 - num2;
int multi = num1 * num2;
float sub = num1/num2;

Console.WriteLine($"The sum is: {sum}, and the difference is {difference}");
Console.WriteLine($"The multiplication is: {multi}, and the subtraction is {sub}");

