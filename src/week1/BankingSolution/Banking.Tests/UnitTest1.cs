namespace Banking.Tests;

public class UnitTest1
{
    [Fact]
    public void CanAddTenAndTwenty()
    {
        // Arrage - Given
        int a = 10;
        int b = 20;
        int answer;

        // Act - When
        answer = a + b;
        // Assert - Then 
        Assert.Equal(30, answer);
    }

    [Theory]
    [InlineData(10,20,30)]
    [InlineData(2,2,4)]
    [InlineData(3,3,6)]
    public void CanAddOtherIntegersToo(int a, int b, int expected)
    {

        int answer = a + b;
        Assert.Equal(expected, answer);
    }
}
