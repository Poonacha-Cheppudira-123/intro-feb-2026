

namespace StringCalculator;

public class CalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new Calculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("212", 212)]
    [InlineData("8", 8)]
    [InlineData("420", 420)]
    public void SingleDigit(string input, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(input);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("2,2", 4)]
    [InlineData("10,2", 12)]
    public void DoubleDigits(string input, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(input);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2,3", 6)]
    [InlineData("1,2,3,4,5,6,7,8,9", 45)]
    public void Arbitrary(string input, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(input);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1\n2\n3", 6)]
    [InlineData("1\n2,3", 6)]
    [InlineData("1\n2,4", 7)]
    [InlineData("1\n2,3,3\n4", 13)]
    public void Mixed(string input, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(input);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("//#\n1#2#3", 6)]
    [InlineData("//#\n1#2#3", 7)]
    public void custom(string input, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(input);

        Assert.Equal(expected, result);
    }
}
