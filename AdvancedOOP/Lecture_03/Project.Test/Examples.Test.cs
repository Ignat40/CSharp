using DemoLibrary;

namespace Project.Test;

public class ExamplesTest
{
    [Fact]
    public void ExampleLoadFile_ValidNameShouldWork()
    {
        string actual = Examples.ExampleLoadFile("This is a valid file name");
        Assert.True(actual.Length > 0);
    }

    [Fact]
    public void ExampleLoadFile_InValidNameShouldFail()
    {
        Assert.Throws<ArgumentException>("file", () => Examples.ExampleLoadFile(""));
    }
}