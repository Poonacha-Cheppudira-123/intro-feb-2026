

using Banking.Domain;
using System.Security.Cryptography;

namespace Banking.Tests;

public class TransactionAmountTests
{
    [Theory]
    [InlineData(0)]
    [InlineData(-0.001)]
    public void ExamplesOfInvalidTransactionAmounts(decimal a)
    {
        Assert.Throws<InvalidTransactionAmountException>(() => TransactionAmount.FromDecimal(a));
    }
    
}
