using DemoLibrary;

namespace Project.Test;

public class CalculatorTest
{
    //[Fact] // -> declares a test method that's run by the test runner. 
    [Theory] // -> Allows us to pass data and run it multiple times. 
    [InlineData(4, 3 ,7)] // -> allows us to populate the values below
    [InlineData(21, 5.25, 26.25)]
    [InlineData(98, 2.001 ,100.001)]
    public void Add_AddTwoValuesTogether(double x, double y, double expected)
    {
        // Arrange -> set up values to test 
        //Done above 

        // Act -> do the actual test
        double actual = Calculator.Add(x, y);

        // Assert -> compare expected value to the actual one and compare
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(8, 4, 2)]
    public void Divide_DivideToValues(double x, double y, double expected)
    {
        double actual = Calculator.Divide(x, y);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Divide_DivideByZero()
    {
        double expected = 0;
        double actual = Calculator.Divide(15, 0);
        Assert.Equal(expected, actual);
    }
}