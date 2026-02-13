
using Banking.Domain;

namespace Banking.Tests;

public class GoldCustomersGetABonus
{

    [Fact]
    public void GoldAccountBonus()
    {
        var account = new Account();
       
        var openingBalance = account.GetBalance();

      
        account.Deposit(100M);

        Assert.Equal(110M + openingBalance, account.GetBalance());

    }

    [Fact]
    public void NonGoldAccountNoBonus()
    {
        var account = new Account();
        var openingBalance = account.GetBalance();
        account.Withdraw(200);
        
        account.Deposit(100M);

        Assert.Equal(100M + openingBalance, account.GetBalance());

    }
}
