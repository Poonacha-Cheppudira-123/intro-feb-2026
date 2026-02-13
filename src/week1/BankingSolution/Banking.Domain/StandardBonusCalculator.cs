

namespace Banking.Domain;

public interface ICalculateBonusesForAccounts
{
    decimal CalculateBonusForDeposit(decimal currentBalance, decimal depositAmount);
}

public class StandardBonusCalculator : ICalculateBonusesForAccounts
{
    public decimal CalculateBonusForDeposit(decimal currentBalance, decimal depositAmount)
    {
        return currentBalance >= 5000M ? depositAmount * .08M : 0;
    }

    public void DoSomething() { }
}

public class SuperDeluxBonusCalculator : ICalculateBonusesForAccounts
{
    public decimal CalculateBonusForDeposit(decimal currentBalance, decimal depositAmount)
    {
        return currentBalance >= 5000M ? depositAmount * .08M : 0;
    }

    public void OtherStuff() { }
}
