

namespace Banking.Tests.NewAccounts;

public class HaveCorrectBalance
{
    [Fact]
    public void BalanceIsCorrect()
    {
        // WTCYWYH - Write the code you wish you had.
        var myAccount = new Account(Substitute.For<ICalculateBonusesForAccounts>());

        decimal openingBalace = myAccount.GetBalance();
        
        // Fails on the Assert.
        Assert.Equal(5000M, openingBalace);
    }
}
