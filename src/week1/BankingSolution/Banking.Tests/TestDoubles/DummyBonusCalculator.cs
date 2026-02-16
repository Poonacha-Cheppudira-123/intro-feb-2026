

namespace Banking.Tests.TestDoubles;

public class DummyBonusCalculator : ICalculateBonusesForAccounts
{
    public decimal CalculateBonusForDeposit(decimal currentBalance, decimal depositAmount)
    {
        return 0;
    }
}
