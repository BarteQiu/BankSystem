class bankAccount
{
    public List<Transaction> Transactions = new List<Transaction>();
    private decimal _balance;
    public decimal Balance
    {
        get { return _balance; }
    }
    private int _id;
    public int Id
    {
        get { return _id; }
    }

    public bankAccount(decimal initialBalance, int Id)
    {
        if(initialBalance < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(initialBalance), "Initial balance cannot be negative.");
        }
        _balance = initialBalance;
        _id = Id;
    }

    public bool depositMoney(decimal amount)
    {
        if (amount <= 0)
            return false;

        Transaction transactionDeposit = new Transaction(amount, Transaction.TransactionType.Deposit);
        Transactions.Add(transactionDeposit);
        _balance += amount;
        return true;
    }

    public bool withdrawMoney(decimal amount)
    {
        if (amount <= 0 || amount > _balance)
            return false;

        Transaction transactionWithdraw = new Transaction(amount, Transaction.TransactionType.Withdraw);
        Transactions.Add(transactionWithdraw);
        _balance -= amount;
        return true;
    }

    public bool AddTransferMoney(decimal amount)
    {
        if (amount <= 0)
            return false;

        Transaction transactionTransfer = new Transaction(amount, Transaction.TransactionType.TransactionIn);
        Transactions.Add(transactionTransfer);
        _balance += amount;
        return true;
    }

    public bool SubstractTransferMoney(decimal amount)
    {
        if (amount <= 0 || _balance < amount)
            return false;

        Transaction transactionTransfer = new Transaction(amount, Transaction.TransactionType.TransactionOut);
        Transactions.Add(transactionTransfer);
        _balance -= amount;
        return true;
    }
}