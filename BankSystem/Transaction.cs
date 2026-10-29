public class Transaction
{
    public decimal Amount { get; set; }
    public TransactionType Type { get; set; }
    public DateTime Date { get; set; }

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
