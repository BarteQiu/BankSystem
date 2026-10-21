class bankAccount
{
    private decimal _balance;
    public decimal Balance
    {
        get { return _balance; }
    }

    public bankAccount(decimal initialBalance)
    {
        if(initialBalance < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(initialBalance), "Initial balance cannot be negative.");
        }
        _balance = initialBalance;
    }

    public void showBalance()
    {
        Console.WriteLine($"Your balance is {Balance:F2}$");
        Console.WriteLine("\n\n\n");
    }

    public bool depositMoney(decimal amount)
    {
        if (amount <= 0)
            return false;

        _balance += amount;
        return true;
    }

    public bool withdrawMoney(decimal amount)
    {
        if (amount <= 0 || amount > _balance)
            return false;

        _balance -= amount;
        return true;
    }
}