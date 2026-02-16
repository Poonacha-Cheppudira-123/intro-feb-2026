
using Banking.Domain;
using Banking.Tests.TestDoubles;

namespace Banking.Tests.MakingWithdrawals;

public class WithdrawDecreasesBalance
{
    [Fact]
    public void Example()
    {
        var account = new Account(new DummyBonusCalculator());


        var openingBalance = account.GetBalance();
        var amountToWithdraw = 123.23M;

        // When I deposit 123.23
        account.Withdraw(amountToWithdraw);


        // Then the balance of that account should increase by that amount
        Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());
    }

    [Fact]
    public void CanWithdrawFullBalance()
    {

        var account = new Account(new DummyBonusCalculator());
        account.Withdraw(account.GetBalance());

        Assert.Equal(0M, account.GetBalance());
    }

    [Fact]
    public void OverdraftIsUnbound()
    {
        var account = new Account(new DummyBonusCalculator());


        var openingBalance = account.GetBalance();
        var amountToWithdraw = openingBalance * 2;

        Assert.Throws<OverdraftNotAllowedException>(() => account.Withdraw(amountToWithdraw));

        Assert.Equal(openingBalance, account.GetBalance());
    }


}
