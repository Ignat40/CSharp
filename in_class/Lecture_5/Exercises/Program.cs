using System;
using System.Diagnostics.Contracts;
using System.Reflection.PortableExecutable;
///<summary>
///Problem: Equality operator
///</summary>
///

string value1 = "a";
string vlaue2 = "A";
Console.WriteLine(value1.Trim().ToLower() == vlaue2.Trim().ToLower());


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
int discount = sum > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

//Or it can be embeded direclty into the the conditional operator inline

Console.WriteLine($"Discount: {(sum > 100 ? 50 : 10)}");

