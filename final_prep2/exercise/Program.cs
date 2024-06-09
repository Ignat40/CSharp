using System.Diagnostics;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

namespace ExamPrep;

public class Program
{
    public static void Main()
    {


        

        //Unit Test Example 
        int[] arr = { 1, 2, 3, 4, 5 }; // sum = 15
                                       //Console.WriteLine(Sum(arr)); // outputs 16

        //Typical test
        //UnitTest.TypicalCaseTest(); // throws excepiton

        // Border Testing
        //UnitTest.BorderCase(); // throws excepiton

        // Special Border Testing
        //UnitTest.SpecialBorderCase(); // throws excepiton

        // Extreme Testing
        //UnitTest.ExtremeCase(); // throws excepiton

        // Null Testing
        //UnitTest.NullTest(); // throws excepiton


        // Performance Testing
        //UnitTest.PerformanceTest(); 

        // Stopwatch sw = Stopwatch.StartNew();

        // int[] numbers = [73, 57, 49, 99, 133, 20, 1];

        // foreach (var n in SeachAndSort.HeapSort(numbers, arr.Length))
        // {
        //     Console.Write($"[{n}] ");
        // }

        // sw.Stop();
        // Console.WriteLine("Time: " + sw.Elapsed.TotalSeconds);

        MultiThreadingAndConcurrenncy.StartThread();
        Console.WriteLine("Thread: " + Thread.CurrentThread.Name);// Gives the currently executing thread.

    }


    // Has several bug to be couaght with unit testing!
    public static long Sum(int[] numbers)
    {
        //int sum = numbers[0];
        //fixed:
        long sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
}