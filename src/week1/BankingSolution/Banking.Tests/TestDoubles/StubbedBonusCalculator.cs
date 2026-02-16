

namespace Banking.Tests.TestDoubles;

public class StubbedBonusCalculator : ICalculateBonusesForAccounts
{
    public decimal CalculateBonusForDeposit(decimal currentBalance, decimal depositAmount)
    {
        if (currentBalance == 5000M && depositAmount == 420.69M)
        {
            return 19M;
        }
        else
        {
            return 0;
        }
    }
}

public class SuperExplodingBonusCalculator : ICalculateBonusesForAccounts
{
    public decimal CalculateBonusForDeposit(decimal currentBalance, decimal depositAmount)
    {
        throw new Exception();
    }
}