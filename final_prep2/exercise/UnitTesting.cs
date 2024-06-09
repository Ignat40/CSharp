namespace ExamPrep;



/*

    Unit Testing -> write a program that test a certain method or a class.
                    A typical unit test executes the method that should be tested, passes a
                    sample data to (parameters and object states) and checks whether the
                    method’s result is correct (for this sample data), i.e. whether the method
                    does exactly what it should do and whether it does it correctly. 

                    single method usually is tested by several unit tests, each implementing a
                    different testing scenario. First, the typical case is checked. Then the border
                    cases are checked. The border cases are special cases which could need
                    special processing logic, e.g. the largest or the smallest possible value, the
                    first or last element, etc. Finally the method is tested with incorrect data
                    and an exception is expected to be thrown. Sometimes a performance test
                    may be involved to check whether the method is fast enough.

    Benefits are:
                    • Improved Code Quality
                    • Allows the tests to be executed many tiems
                      e.g. every out to catch the problem quickly
                      That's called CONTINUOIS INTEGRATION
                    • The code quality is preserved everytime the method is modified.
                      This simplifies the maintenance.
                    • Allow Code Refactoring    

    Attributes --> [Fact]: declates a test method that's run by the test runner.
                   [Theory]: represents a suite of tests that execute the samae code but have different input arguments
                   [InlineDate]: specifies values for those inputs

    MOCK & STUB -> Mock: used when you need to test interactions between objects, i.e., 
                         to ensure that a method was called with specific arguments, or a specific number of times.
                   Stub: primarily used when you need to control the environment of the test. 
                         They are useful for providing indirect inputs to the system under test.

    Magic String-> hardcoded strign literals that appear in the test code
                   without explanantion or context. They make the code hardred to read.

    !!! Using logic in tests should be avoided !!!

    


*/


public class UnitTest
{

    public static void TypicalCaseTest()
    {
        if (Program.Sum([1, 2]) != 3)
            throw new Exception("1 + 2 != 3");
    }

    public static void BorderCase()
    {
        if (Program.Sum(new int[] { }) != 0)
            throw new Exception("Sum of 0 numbers != 0");
    }

    public static void SpecialBorderCase()
    {
        if (Program.Sum(new int[] { -1, -2 }) != -3)
            throw new Exception("- 1 + -2 != -3");
    }

    public static void ExtremeCase()
    {
        if (Program.Sum(new int[] { 2000000000, 2000000000 }) != 4000000000)
            throw new Exception("2000000000 + 2000000000 != 4000000000");
    }

    public static void NullTest()
    {
        try
        {
            Program.Sum(null);
            // An exception is expected --> the test fails
            throw new Exception("Null array cannot be summed.");
        }
        catch (NullReferenceException)
        {
            // NullReferenceException is expected --> the test passes
        }
    }

    public static void PerformanceTest()
    {
        DateTime startTime = DateTime.Now;
        int[] arr = new int[10000000];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = 5;
        }
        if (Program.Sum(arr) != 50000000)
            throw new Exception("5 + ... (10000000 times) != 50000000");
        DateTime endTime = DateTime.Now;
        if (endTime - startTime > new TimeSpan(0, 0, 1))
            throw new Exception("Performance issue: summing 10000000 " +
            "numbers takes more that 1 second");
    }
}