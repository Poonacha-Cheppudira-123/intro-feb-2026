


namespace Banking.Domain;

public class Account
{
    private decimal _currentBalance = 5000M;

    public void Deposit(decimal amountToDeposit)
    {
  
        _currentBalance += amountToDeposit;
    }

    public decimal GetBalance()
    {

        return _currentBalance;
    }

    // Primitive Obsession 
    public void Withdraw(decimal amountToWithdraw)
    {
        if (IsAllowedTransactionAmount(amountToWithdraw))
        {
            if (amountToWithdraw <= _currentBalance)
            {

                _currentBalance -= amountToWithdraw;
            }
            
        }
    }

    private  bool IsAllowedTransactionAmount(decimal amountToWithdraw)
    {
        return amountToWithdraw > 0;
    }
}