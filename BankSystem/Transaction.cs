public class Transaction
{
    public decimal Amount { get; }
    public TransactionType Type { get; }
    public DateTime Date { get; }

    public enum TransactionType
    {
        Deposit,
        Withdraw
    }

    public Transaction(decimal amount, TransactionType type)
    {
        Amount = amount;
        Type = type;
        Date = DateTime.Now;
    }
}
