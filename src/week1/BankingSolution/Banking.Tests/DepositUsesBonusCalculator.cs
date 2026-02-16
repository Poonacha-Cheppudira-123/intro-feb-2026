using Banking.Domain;
using Banking.Tests.TestDoubles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Tests;

public class DepositUsesBonusCalculator
{

    [Fact]
    public void IntegratesProperly()
    {
        // Given
        var stubbedBonusCalculator = Substitute.For<ICalculateBonusesForAccounts>();
        var account = new Account(stubbedBonusCalculator);
        var openingBalance = account.GetBalance();
        var amountToDeposit = 420.69M;
        stubbedBonusCalculator.CalculateBonusForDeposit(openingBalance, amountToDeposit).Returns(19M);



        // When
        account.Deposit(amountToDeposit);
        // then
        Assert.Equal(openingBalance + 420.69M + 19M, account.GetBalance());

    }
}
