

namespace StringCalculator;
public class CalculatorTests
{

    private Calculator _calculator;

    public CalculatorTests()
    {
        _calculator = new Calculator();
    }
    [Fact]
    public void EmptyStringReturnsZero()
    {
       

        var result = _calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("2", 2)]
    [InlineData("42", 42)]
    
    public void SingleNumberReturnsValue(string input, int expected)
    {
      
        var result = _calculator.Add(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("2,2", 4)]
    [InlineData("1,2,3,4,5,6,7,8,9", 45)]
    public void MultipleNumbers(string input, int expected)
    {

        var result = _calculator.Add(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1\n2", 3)]
    
    
    public void Mixed(string input, int expected)
    {

        var result = _calculator.Add(input);
        Assert.Equal(expected, result);
    }



}
