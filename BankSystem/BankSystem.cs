class bankSystem
{
    private bankAccount _account;
    public bankSystem()
    {
        _account = new bankAccount(11.36m);
    }
    public void showBalance()
    {
        Console.WriteLine($"Your balance is {_account.Balance:F2}$");
        Console.WriteLine("\n\n\n");
    }
    public void depositMoney()
    {
        Console.Clear();
        Console.WriteLine($"How much money do you want to deposit?");

        string Deposit = Console.ReadLine();

        if (!decimal.TryParse(Deposit, out decimal userDeposit))
        {
            Console.WriteLine("Invalid amount. Please enter a number.");
            Console.WriteLine("\n\n\n");
            return;
        }

        if (userDeposit <= 0)
        {
            Console.WriteLine("Amount must be higher than zero. Try again.");
            Console.WriteLine("\n\n\n");
            return;
        }
        _account.depositMoney(userDeposit);

        Console.WriteLine("Deposit successful.");
        Console.WriteLine($"\nYour balance is {_account.Balance:F2}$");
        Console.WriteLine("\n\n\n");
    }

    public void withdrawMoney()
    {
        Console.Clear();
        Console.WriteLine($"How much money do you want to withdraw?");

        string Withdraw = Console.ReadLine();

        if (!decimal.TryParse(Withdraw, out decimal userWithdraw))
        {
            Console.WriteLine("Invalid amount. Please enter a number.");
            Console.WriteLine("\n\n\n");
            return;
        }

        if (userWithdraw <= 0)
        {
            Console.WriteLine("Amount must be higher than zero. Please try again.");
            Console.WriteLine("\n\n\n");
            return;
        }

        if (_account.Balance < userWithdraw)
        {
            Console.WriteLine("You don't have enough money to withdraw");
            Console.WriteLine("\n\n\n");
            return;
        }
        _account.withdrawMoney(userWithdraw);

        Console.WriteLine("Deposit successful.");

        Console.WriteLine($"\nYour balance is {_account.Balance:F2}$");
        Console.WriteLine("\n\n\n");
    }
}