namespace EngineOutput.Tests;

public class EngineOutputTest
{
    [Fact]
    public void TestIfOutputTimesOutputMultiplierIsGreaterThan20()
    {
        //arrange
        long total;
        EngineOutput objectOutput = new EngineOutput();
        //act
        total = objectOutput.TotalOutput(10, 3);
        //assert
        Assert.True(total>20);
    }
}