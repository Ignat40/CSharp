using System.Reflection.PortableExecutable;
using System.Transactions;
using System.Xml.XPath;

namespace ExamPrep;


// Recursion -> powerful technique which a meathod makes a call to itself
//              from withiin its own method body. Sometimes its usage could considerably
//              simplify the programming code and its readability.

// Direct Recursion -> When in the body of a method there is a call to the same method, we say that
//                     the method is directly recursive

// Indirect Recursion -> If method A calls method B, method B calls method C, and method C calls
//                       method A we call the methods A, B and C indirectly recursive or mutually
//                       recursive.

// Bottom of recursion -> we have to be totally sure that after a certain count of
//                        steps we get a concrete result. For this reason we should have one or more
//                        cases in which the solution could be found directly, without a recursive call.
//                        These cases are called bottom of recursion.
//
//                        !!! If a recursive method has no base case, i.e. bottom, it will become infinite and the result will be StackOverflowException.

// Which is better: Recursion or Iteration -> If by using recursion we reach a simpler, shorter and easier
//                        for understanding solution, not causing inefficiency and
//                        other side effects, then we can prefer recursive solution.
//                        Otherwise, it is better to think of iteration..

// MEMOIZATION -> technique used in computer science to improve the performance of algorithms
//                        by storing the results of expensive function calls and reusing them
//                        when the same inputs occur again, reducing time complexity.




public class Recursion
{

    // Common example of recursion
    public static int FibonacciNumbers(int n)
    {

        if (n <= 2)
            return 1;
        else
            return FibonacciNumbers(n - 1) + FibonacciNumbers(n - 2);

    }

    public static int RecursiveFact(int n)
    {

        if (n == 1 || n == 0)
            return 1;
        if (n == 2)
            return n;

        return n * RecursiveFact(n - 1);
    }

    public static void NestedLoops(int currentLoop)
    {
        //hard coded for testing purpose
        int numberOfLoops = 5;
        int numberOfIterations = 5;
        int[] loops = [];

        if (currentLoop == numberOfLoops)
        {
            PrintLoops();
            return;
        }
        for (int counter = 1; counter <= numberOfIterations; counter++)
        {
            loops[currentLoop] = counter;
            NestedLoops(currentLoop + 1);
        }
    }

    private static void PrintLoops()
    {


        //hard coded for testing purpose
        int numberOfLoops = 5;
        int numberOfIterations = 5;
        int[] loops = [];

        for (int i = 0; i < numberOfLoops; i++)
        {
            Console.Write("{0} ", loops[i]);
        }
        Console.WriteLine();
    }

    public static void Labyrinth(int row, int col)
    {

        char[,] lab =
        {
            {'s', ' ', ' ','*' , ' ', ' ', ' '},
            {'*', '*', ' ','*' , ' ', '*', ' '},
            {' ', ' ', ' ',' ' , ' ', ' ', ' '},
            {' ', '*', '*','*' , '*', '*', ' '},
            {' ', ' ', ' ',' ' , ' ', ' ', 'e'},
        };

        if ((col < 0) || (row < 0) ||
        (col >= lab.GetLength(1)) || (row >= lab.GetLength(0)))
        {
            // We are out of the labyrinth
            return;
        }
        // Check if we have found the exit
        if (lab[row, col] == 'e')
        {
            Console.WriteLine("Found the exit!");
        }
        if (lab[row, col] != ' ')
        {
            // The current cell is not free
            return;
        }
        // Mark the current cell as visited
        lab[row, col] = 's';
        // Invoke recursion to explore all possible directions
        Labyrinth(row, col - 1); // left
        Labyrinth(row - 1, col); // up
        Labyrinth(row, col + 1); // right
        Labyrinth(row + 1, col); // down
                                // Mark back the current cell as free
        lab[row, col] = ' ';
    }



}