
namespace Banking.Domain;

public class InvalidTransactionAmountException : ArgumentOutOfRangeException { }
public class TransactionAmount
{
    private decimal Value { get;  }
    private TransactionAmount(decimal amount)
    {
        if (amount <= 0)
        {
            throw new InvalidTransactionAmountException();
        } else
        {
            Value = amount;
        }
    }


    public static TransactionAmount FromDecimal(decimal amount)
    {
        return new TransactionAmount(amount);
    }

    public static TransactionAmount FromInt(int amount)
    {
        return new TransactionAmount(amount);
    }

    public static TransactionAmount FromString(string amount)
    {
        if (decimal.TryParse(amount, out decimal val))
        {
            return new TransactionAmount(val);

        }
        else
        {
            throw new InvalidTransactionAmountException();

        }
    }

    public static implicit operator Decimal(TransactionAmount amount) => amount.Value;
    public static implicit operator TransactionAmount(decimal value) => new(value);
    
}
