



using Banking.Domain;
using Banking.Tests.TestDoubles;

namespace Banking.Tests.MakingDeposits;

public class DepositsIncreaseBalance
{
    [Fact]
    public void Depositing()
    {
        // Given I have a brand new account and I get the opening balance
        var account = new Account(new DummyBonusCalculator());
       

        var openingBalance = account.GetBalance();
        var amountToDeposit = 123.23M;

        // When I deposit 123.23
        account.Deposit(amountToDeposit);


        // Then the balance of that account should increase by that amount
        Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());
    }
}
