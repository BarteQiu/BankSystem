using System.Data.Common;
using System.Security.Principal;
using System.Transactions;
using static Transaction;

class bankSystem
{
    private ConsoleUI ConsoleUI = new ConsoleUI();
    private List<bankAccount> _accounts = new List<bankAccount>();

    int userId = 3;
    // Numbers 0, 1, and 2 have been taken by example accounts.

    public bankSystem()
    {
        _accounts.Add(new bankAccount(748, 1));
        _accounts.Add(new bankAccount(192, 2));
        _accounts.Add(new bankAccount(399, 3));

        // Account 1
        _accounts[0].Transactions.Add(
            new Transaction(200, Transaction.TransactionType.Deposit));

        _accounts[0].Transactions.Add(
            new Transaction(50, Transaction.TransactionType.Withdraw));

        _accounts[0].Transactions.Add(
            new Transaction(100, Transaction.TransactionType.Deposit));

        // Account 2
        _accounts[1].Transactions.Add(
            new Transaction(100, Transaction.TransactionType.Deposit));

        _accounts[1].Transactions.Add(
            new Transaction(25, Transaction.TransactionType.Withdraw));

        // Account 3
        _accounts[2].Transactions.Add(
            new Transaction(500, Transaction.TransactionType.Deposit));

        _accounts[2].Transactions.Add(
            new Transaction(101, Transaction.TransactionType.Withdraw));
    }

    public void showBalance()
    {
        Console.Clear();

        ConsoleUI.grayText("Ender account ID: ");
        string ID = Console.ReadLine();

        if (!int.TryParse(ID, out int accountId))
        {
            Console.WriteLine("\n");
            ConsoleUI.ShowSeparator();
            ConsoleUI.ShowError("Invalid account ID.");
            ConsoleUI.ShowSeparator();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("        Press any key to continue...");

            Console.ReadKey(true);

            Console.Clear();

            return;
        }

        var account = _accounts.SingleOrDefault(a => a.Id == accountId);

        if (account == null)
        {
            Console.WriteLine("\n");
            ConsoleUI.ShowSeparator();
            ConsoleUI.ShowError("Account does not exist.");
            ConsoleUI.ShowSeparator();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("        Press any key to continue...");

            Console.ReadKey(true);

            Console.Clear();
            return;
        }

        Console.Clear();

        ConsoleUI.ShowSeparator();
        ConsoleUI.ShowHeader("                BALANCE");
        ConsoleUI.ShowSeparator();
        Console.WriteLine();
        Console.WriteLine($" Account ID   : {account.Id}");
        Console.WriteLine($" Balance      : {account.Balance:F2}$");
        Console.WriteLine();
        ConsoleUI.ShowSeparator();
        Console.WriteLine();
        Console.WriteLine("        Press any key to continue...");

        Console.ReadKey(true);

        Console.Clear();
    }

    public void depositMoney()
    {
        Console.Clear();
        ConsoleUI.ShowSeparator();
        ConsoleUI.ShowHeader("              DEPOSIT MONEY");
        ConsoleUI.ShowSeparator();

        Console.WriteLine("\n");

        Console.WriteLine($"How much money do you want to deposit?");
        string Deposit = Console.ReadLine();

        if (!decimal.TryParse(Deposit, out decimal userDeposit))
        {
            Console.WriteLine("\n");
            ConsoleUI.ShowSeparator();
            ConsoleUI.ShowError("Invalid amount. Please enter a number.");
            ConsoleUI.ShowSeparator();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("        Press any key to continue...");

            Console.ReadKey(true);

            Console.Clear();
            return;
        }

        if (userDeposit <= 0)
        {
            Console.WriteLine("\n");
            ConsoleUI.ShowSeparator();
            ConsoleUI.ShowError("Amount must be higher than zero.");
            ConsoleUI.ShowSeparator();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("        Press any key to continue...");

            Console.ReadKey(true);

            Console.Clear();
            return;
        }

        ConsoleUI.grayText("Ender account ID: ");
        string ID = Console.ReadLine();

        if (!int.TryParse(ID, out int accountId))
        {
            Console.WriteLine("\n");
            ConsoleUI.ShowSeparator();
            ConsoleUI.ShowError("Invalid account ID.");
            ConsoleUI.ShowSeparator();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("        Press any key to continue...");

            Console.ReadKey(true);

            Console.Clear();
            return;
        }

        var account = _accounts.SingleOrDefault(a => a.Id == accountId);

        if(account == null)
        {
            Console.WriteLine("\n");
            ConsoleUI.ShowSeparator();
            ConsoleUI.ShowError("Account does not exist.");
            ConsoleUI.ShowSeparator();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("        Press any key to continue...");

            Console.ReadKey(true);

            Console.Clear();

            return;
        }



        Console.Clear();

        decimal newBalance = account.Balance + userDeposit;

        ConsoleUI.ShowSeparator();
        ConsoleUI.ShowHeader("              DEPOSIT MONEY");
        ConsoleUI.ShowSeparator();
        Console.WriteLine();
        Console.WriteLine($" Account ID          : {account.Id}");
        Console.WriteLine($" Previous balance    : {account.Balance:F2}$");
        Console.WriteLine($" Deposit amount      : {userDeposit}$");
        Console.WriteLine();
        ConsoleUI.ShowSeparator();
        Console.WriteLine();
        ConsoleUI.ShowSuccess("Deposit successful.");
        Console.WriteLine();
        Console.WriteLine($" NEW BALANCE           {newBalance}$");
        Console.WriteLine();
        ConsoleUI.ShowSeparator();
        Console.WriteLine("        Press any key to continue...");

        Console.ReadKey(true);

        account.depositMoney(userDeposit);

        Console.Clear();
    }

    public void withdrawMoney()
    {
        Console.Clear();
        ConsoleUI.ShowSeparator();
        ConsoleUI.ShowHeader("              WITHDRAW MONEY");
        ConsoleUI.ShowSeparator();

        Console.WriteLine("\n");

        Console.WriteLine($"How much money do you want to withdraw?");

        string Withdraw = Console.ReadLine();

        if (!decimal.TryParse(Withdraw, out decimal userWithdraw))
        {
            Console.WriteLine("\n");
            ConsoleUI.ShowSeparator();
            ConsoleUI.ShowError("Invalid amount. Please enter a number.");
            ConsoleUI.ShowSeparator();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("        Press any key to continue...");

            Console.ReadKey(true);

            Console.Clear();
            return;
        }

        if (userWithdraw <= 0)
        {
            Console.WriteLine("\n");
            ConsoleUI.ShowSeparator();
            ConsoleUI.ShowError("Amount must be higher than zero. Please try again.");
            ConsoleUI.ShowSeparator();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("        Press any key to continue...");

            Console.ReadKey(true);

            Console.Clear();

            return;
        }

        Console.WriteLine("Ender account ID: ");
        string ID = Console.ReadLine();

        if (!int.TryParse(ID, out int accountId))
        {
            Console.WriteLine("\n");
            ConsoleUI.ShowSeparator();
            ConsoleUI.ShowError("Invalid account ID.");
            ConsoleUI.ShowSeparator();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("        Press any key to continue...");

            Console.ReadKey(true);

            Console.Clear();

            return;
        }

        var account = _accounts.SingleOrDefault(a => a.Id == accountId);

        if (account == null)
        {
            Console.WriteLine("\n");
            ConsoleUI.ShowSeparator();
            ConsoleUI.ShowError("Account does not exist.");
            ConsoleUI.ShowSeparator();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("        Press any key to continue...");

            Console.ReadKey(true);

            Console.Clear();

            return;
        }

        if (account.Balance < userWithdraw)
        {
            Console.WriteLine("\n");
            ConsoleUI.ShowSeparator();
            ConsoleUI.ShowInfo("You don't have enough money to withdraw");
            ConsoleUI.ShowSeparator();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("        Press any key to continue...");

            Console.ReadKey(true);

            Console.Clear();

            return;
        }



        Console.Clear();

        decimal newBalance = account.Balance - userWithdraw;

        ConsoleUI.ShowSeparator();
        ConsoleUI.ShowHeader("              WITHDRAW MONEY");
        ConsoleUI.ShowSeparator();
        Console.WriteLine();
        Console.WriteLine($" Account ID          : {account.Id}");
        Console.WriteLine($" Previous balance    : {account.Balance:F2}$");
        Console.WriteLine($" Withdraw amount     : {userWithdraw}$");
        Console.WriteLine();
        ConsoleUI.ShowSeparator();
        Console.WriteLine();
        ConsoleUI.ShowSuccess("Withdraw successful.");
        Console.WriteLine();
        Console.WriteLine($" NEW BALANCE           {newBalance}$");
        Console.WriteLine();
        ConsoleUI.ShowSeparator();
        Console.WriteLine("        Press any key to continue...");

        Console.ReadKey(true);

        account.withdrawMoney(userWithdraw);

        Console.Clear();
    }

    public void ShowTransactionHistoryMenu()
    {
        Console.Clear();

        ConsoleUI.ShowSeparator();
        ConsoleUI.ShowHeader("           TRANSACTION HISTORY");
        ConsoleUI.ShowSeparator();

        ConsoleUI.grayText("Ender account ID: ");
        string ID = Console.ReadLine();

        if (!int.TryParse(ID, out int accountId))
        {
            Console.WriteLine("\n");
            ConsoleUI.ShowSeparator();
            ConsoleUI.ShowError("Invalid account ID.");
            ConsoleUI.ShowSeparator();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("        Press any key to continue...");

            Console.ReadKey(true);

            Console.Clear();

            return;
        }

        var account = _accounts.SingleOrDefault(a => a.Id == accountId);

        if (account == null)
        {
            Console.WriteLine("\n");
            ConsoleUI.ShowSeparator();
            ConsoleUI.ShowError("Account does not exist.");
            ConsoleUI.ShowSeparator();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("        Press any key to continue...");

            Console.ReadKey(true);

            Console.Clear();

            return;
        }

        Console.Clear();

        ConsoleUI.ShowSeparator();
        ConsoleUI.ShowHeader("           TRANSACTION HISTORY");
        ConsoleUI.ShowSeparator();

        ConsoleUI.ShowSeparator();
        ConsoleUI.grayText($"  Choosen ID: {ID} \n");
        ConsoleUI.ShowSeparator();

        ConsoleUI.greenText("  [1]  All history \n");
        ConsoleUI.greenText("  [2]  Deposit history \n");
        ConsoleUI.greenText("  [3]  Withdraw history \n");
        ConsoleUI.redText("  [0]  Exit \n");

        ConsoleUI.ShowSeparator();

        Console.Write("  Choose option:");

        string chooseHistory = Console.ReadLine();

        if (!int.TryParse(chooseHistory, out int userChoice))
        {
            Console.WriteLine("\n");
            ConsoleUI.ShowSeparator();
            ConsoleUI.ShowError("Please enter a valid number.");
            ConsoleUI.ShowSeparator();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("        Press any key to continue...");

            Console.ReadKey(true);

            Console.Clear();
            return;
        }

        switch (userChoice)
        {
            case 1:
                var allHistory = account.Transactions
                     .OrderByDescending(p => p.Date);

                Console.Clear();
                ConsoleUI.ShowHeader("====== TransactionHistory ======");

                if (account.Transactions.Count == 0)
                {
                    ConsoleUI.ShowInfo("You dont have transaction history.");
                }

                foreach (Transaction transaction in allHistory)
                {
                    string transactionName = transaction.Type switch
                    {
                        Transaction.TransactionType.Deposit => "Deposit",
                        Transaction.TransactionType.Withdraw => "Withdraw",
                        Transaction.TransactionType.TransactionIn => "Transfer In",
                        Transaction.TransactionType.TransactionOut => "Transfer Out"
                    };

                    if (transaction.Type == Transaction.TransactionType.Deposit)
                    {
                        Console.Write($"[ {transaction.Date.ToString("HH:mm:ss dd.MM.yyyy")} ] | ");
                        ConsoleUI.greenText($"{transactionName} ");
                        Console.Write($"     | {transaction.Amount}$ \n");
                    }

                    if (transaction.Type == Transaction.TransactionType.Withdraw)
                    {
                        Console.Write($"[ {transaction.Date.ToString("HH:mm:ss dd.MM.yyyy")} ] | ");
                        ConsoleUI.redText($"{transactionName}");
                        Console.Write($"     | {transaction.Amount}$ \n");
                    }

                    if (transaction.Type == Transaction.TransactionType.TransactionIn)
                    {
                        Console.Write($"[ {transaction.Date.ToString("HH:mm:ss dd.MM.yyyy")} ] | ");
                        ConsoleUI.greenText($"{transactionName}");
                        Console.Write($"  | {transaction.Amount}$ \n");
                    }

                    if (transaction.Type == Transaction.TransactionType.TransactionOut)
                    {
                        Console.Write($"[ {transaction.Date.ToString("HH:mm:ss dd.MM.yyyy")} ] | ");
                        ConsoleUI.redText($"{transactionName}");
                        Console.Write($" | {transaction.Amount}$ \n");
                    }
                }

                ConsoleUI.ShowHeader("================================ \n");
                Console.WriteLine("        Press any key to continue...");

                Console.ReadKey(true);

                Console.Clear();
                break;
            case 2:
                var depoHistory = account.Transactions
                    .OrderByDescending(p => p.Date)
                    .Where(p => p.Type == Transaction.TransactionType.Deposit 
                             || p.Type == Transaction.TransactionType.TransactionIn);

                Console.Clear();
                ConsoleUI.ShowHeader("====== TransactionHistory ======");

                if (!depoHistory.Any())
                {
                    ConsoleUI.ShowInfo("You dont have deposit history.");
                }

                foreach (Transaction transaction in depoHistory)
                {
                    string transactionName = transaction.Type switch
                    {
                        Transaction.TransactionType.Deposit => "Deposit",
                        Transaction.TransactionType.TransactionIn => "Transfer In",
                    };

                    if (transaction.Type == Transaction.TransactionType.Deposit)
                    {
                        Console.Write($"[ {transaction.Date.ToString("HH:mm:ss dd.MM.yyyy")} ] | ");
                        ConsoleUI.greenText($"{transactionName} ");
                        Console.Write($"     | {transaction.Amount}$ \n");
                    }

                    if (transaction.Type == Transaction.TransactionType.TransactionIn)
                    {
                        Console.Write($"[ {transaction.Date.ToString("HH:mm:ss dd.MM.yyyy")} ] | ");
                        ConsoleUI.greenText($"{transactionName}");
                        Console.Write($"  | {transaction.Amount}$ \n");
                    }
                }

                ConsoleUI.ShowHeader("================================ \n");
                Console.WriteLine("        Press any key to continue...");

                Console.ReadKey(true);

                Console.Clear();
                break;
            case 3:
                var withHistory = account.Transactions
                    .OrderByDescending(p => p.Date)
                    .Where(p => p.Type == Transaction.TransactionType.Withdraw
                             || p.Type == Transaction.TransactionType.TransactionOut);

                Console.Clear();
                ConsoleUI.ShowHeader("====== TransactionHistory ======");

                if (!withHistory.Any())
                {
                    ConsoleUI.ShowInfo("You dont have withdrawal history.");
                }

                foreach (Transaction transaction in withHistory)
                {
                    string transactionName = transaction.Type switch
                    {
                        Transaction.TransactionType.Withdraw => "Withdraw",
                        Transaction.TransactionType.TransactionOut => "Transfer Out"
                    };

                    if (transaction.Type == Transaction.TransactionType.Withdraw)
                    {
                        Console.Write($"[ {transaction.Date.ToString("HH:mm:ss dd.MM.yyyy")} ] | ");
                        ConsoleUI.redText($"{transactionName}");
                        Console.Write($"     | {transaction.Amount}$ \n");
                    }

                    if (transaction.Type == Transaction.TransactionType.TransactionOut)
                    {
                        Console.Write($"[ {transaction.Date.ToString("HH:mm:ss dd.MM.yyyy")} ] | ");
                        ConsoleUI.redText($"{transactionName}");
                        Console.Write($" | {transaction.Amount}$ \n");
                    }
                }

                ConsoleUI.ShowHeader("================================ \n");
                Console.WriteLine("        Press any key to continue...");

                Console.ReadKey(true);

                Console.Clear();
                break;
            case 0:
                Console.Clear();
                return;
        }


    }

    public void accounts()
    {
        Console.Clear();
        showMenuAccount();

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("  [1] Show all accounts");
        Console.WriteLine("  [2] Create new account");
        Console.WriteLine("  [3] Search account by ID");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("  [0] Back to main menu");
        Console.ResetColor();

        ConsoleUI.ShowSeparator();

        Console.Write("  Select an option: ");

        bool programIsOn = true;
        string userChoice = Console.ReadLine();

        if (!int.TryParse(userChoice, out int userAccountChoice))
        {
            Console.Clear();
            Console.WriteLine("\n");
            ConsoleUI.ShowSeparator();
            ConsoleUI.ShowError("Please enter a valid number.");
            ConsoleUI.ShowSeparator();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("        Press any key to continue...");

            Console.ReadKey(true);

            Console.Clear();
            return;
        }


        while (programIsOn)
        {
            switch (userAccountChoice)
            {
                case 1:
                    showAllAccounts();
                    programIsOn = false;
                    break;
                case 2:
                    addAccount();
                    programIsOn = false;
                    break;
                case 3:
                    searchAccount();
                    programIsOn = false;
                    break;
                case 0:
                    Console.Clear();
                    programIsOn = false;
                    return;
                default:
                    Console.WriteLine("\n");
                    ConsoleUI.ShowSeparator();
                    ConsoleUI.ShowError("Wrong option. Try again.");
                    ConsoleUI.ShowSeparator();
                    Console.WriteLine("\n\n\n");

                    Console.WriteLine("        Press any key to continue...");

                    Console.ReadKey(true);

                    Console.Clear();
                    return;
            }
        }

    }

    public void showAllAccounts()
    {
        Console.Clear();

        if (_accounts.Count == 0)
        {
            Console.Clear();
            Console.WriteLine("\n");
            ConsoleUI.ShowSeparator();
            ConsoleUI.ShowInfo("No accounts found.");
            ConsoleUI.ShowSeparator();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("        Press any key to continue...");

            Console.ReadKey(true);

            Console.Clear();
            return;

        }

        foreach (bankAccount acc in _accounts)
        {
            ConsoleUI.ShowSeparator();
            Console.WriteLine();
            Console.WriteLine($" Account ID  : {acc.Id}");
            Console.WriteLine($" balance     : {acc.Balance:F2}$");
            Console.WriteLine();
            ConsoleUI.ShowSeparator();
            Console.WriteLine();
        }

        Console.WriteLine("        Press any key to continue...");

        Console.ReadKey(true);
        Console.Clear();

    }

    public void addAccount()
    {
        Random random = new Random();

        int startBalance = random.Next(0, 10000);
        userId += 1;

        _accounts.Add(new bankAccount(startBalance, userId));

        Console.Clear();

        ConsoleUI.ShowSeparator();
        Console.WriteLine();
        Console.WriteLine($" Account ID  : {userId}");
        Console.WriteLine($" balance     : {startBalance:F2}$");
        Console.WriteLine();
        ConsoleUI.ShowSeparator();
        ConsoleUI.ShowSuccess("Account has been created!");
        
        Console.WriteLine();
        Console.WriteLine("        Press any key to continue...");

        Console.ReadKey(true);

        Console.Clear();
    }

    public void searchAccount()
    {
        Console.Clear();
        Console.Write("enter the account ID you are looking for: ");
        string searchingId = Console.ReadLine();

        Console.Clear();

        if (!int.TryParse(searchingId, out int searchingUserId))
        {
            Console.WriteLine("\n");
            ConsoleUI.ShowSeparator();
            ConsoleUI.ShowError("Invalid account ID. Please enter a number.");
            ConsoleUI.ShowSeparator();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("        Press any key to continue...");

            Console.ReadKey(true);

            Console.Clear();
            return;
        }

        var searchedAcc = _accounts
            .SingleOrDefault(a => a.Id == searchingUserId);

        if (searchedAcc == null)
        {
            Console.WriteLine("\n");
            ConsoleUI.ShowSeparator();
            ConsoleUI.ShowError("This account does not exist!");
            ConsoleUI.ShowSeparator();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("        Press any key to continue...");

            Console.ReadKey(true);

            Console.Clear();
            return;
        }

        var allHistory = searchedAcc.Transactions
            .OrderByDescending(p => p.Date);

        Console.Clear();

        ConsoleUI.ShowSeparator();
        Console.WriteLine();
        Console.WriteLine($" Account ID  : {searchedAcc.Id}");
        Console.WriteLine($" balance     : {searchedAcc.Balance:F2}$ \n");

        if (!searchedAcc.Transactions.Any())
        {
            ConsoleUI.ShowInfo("This account doesn't have transaction history");
        }

        foreach (Transaction transaction in allHistory)
        {
            string transactionName = transaction.Type switch
            {
                Transaction.TransactionType.Deposit => "Deposit",
                Transaction.TransactionType.Withdraw => "Withdraw",
                Transaction.TransactionType.TransactionIn => "Transfer In",
                Transaction.TransactionType.TransactionOut => "Transfer Out",
            };

            if (transaction.Type == Transaction.TransactionType.Deposit)
            {
                Console.Write($"[ {transaction.Date.ToString("HH:mm:ss dd.MM.yyyy")} ] | ");
                ConsoleUI.greenText($"{transactionName} ");
                Console.Write($" | {transaction.Amount}$ \n");
            }

            if (transaction.Type == Transaction.TransactionType.TransactionIn)
            {
                Console.Write($"[ {transaction.Date.ToString("HH:mm:ss dd.MM.yyyy")} ] | ");
                ConsoleUI.greenText($"{transactionName} ");
                Console.Write($" | {transaction.Amount}$ \n");
            }

            if (transaction.Type == Transaction.TransactionType.Withdraw)
            {
                Console.Write($"[ {transaction.Date.ToString("HH:mm:ss dd.MM.yyyy")} ] | ");
                ConsoleUI.redText($"{transactionName}");
                Console.Write($" | {transaction.Amount}$ \n");
            }

            if (transaction.Type == Transaction.TransactionType.TransactionOut)
            {
                Console.Write($"[ {transaction.Date.ToString("HH:mm:ss dd.MM.yyyy")} ] | ");
                ConsoleUI.redText($"{transactionName}");
                Console.Write($" | {transaction.Amount}$ \n");
            }
        }

        Console.WriteLine();
        ConsoleUI.ShowSeparator();
        Console.WriteLine();
        Console.WriteLine("        Press any key to continue...");

        Console.ReadKey(true);

        Console.Clear();

        Console.WriteLine("\n");
    }

    public void transferMoney()
    {
        Console.Clear();

        ConsoleUI.ShowSeparator();
        ConsoleUI.ShowHeader("             TRANSFER MONEY");
        ConsoleUI.ShowSeparator();
        Console.WriteLine("\n");

        ConsoleUI.grayText("Enter the ID of the account to transfer money from: ");
        string sourceIdInput = Console.ReadLine();

        if (!int.TryParse(sourceIdInput, out int accountId1))
        {
            Console.WriteLine("\n");
            ConsoleUI.ShowSeparator();
            ConsoleUI.ShowError("Invalid account ID.");
            ConsoleUI.ShowSeparator();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("        Press any key to continue...");

            Console.ReadKey(true);

            Console.Clear();

            return;
        }

        ConsoleUI.grayText("Enter the ID of the account to transfer money to: ");
        string destinationIdInput = Console.ReadLine();

        if (!int.TryParse(destinationIdInput, out int accountId2))
        {
            Console.WriteLine("\n");
            ConsoleUI.ShowSeparator();
            ConsoleUI.ShowError("Invalid account ID.");
            ConsoleUI.ShowSeparator();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("        Press any key to continue...");

            Console.ReadKey(true);

            Console.Clear();

            return;
        }

        var account1 = _accounts.SingleOrDefault(a => a.Id == accountId1);
        var account2 = _accounts.SingleOrDefault(a => a.Id == accountId2);

        if (account1 == null || account2 == null)
        {
            Console.WriteLine("\n");
            ConsoleUI.ShowSeparator();
            ConsoleUI.ShowError("Account does not exist.");
            ConsoleUI.ShowSeparator();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("        Press any key to continue...");

            Console.ReadKey(true);

            Console.Clear();

            return;
        }

        if (account1.Id == account2.Id)
        {
            Console.Clear();
            Console.WriteLine("\n");
            ConsoleUI.ShowSeparator();
            ConsoleUI.ShowError("Cannot transfer money to the same account.");
            ConsoleUI.ShowSeparator();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("        Press any key to continue...");

            Console.ReadKey(true);

            Console.Clear();

            return;
        }

        ConsoleUI.grayText("Enter the transfer amount: ");
        string Amount = Console.ReadLine();

        if (!decimal.TryParse(Amount, out decimal transferAmount))
        {
            Console.WriteLine("\n");
            ConsoleUI.ShowSeparator();
            ConsoleUI.ShowError("Invalid transfer amount.");
            ConsoleUI.ShowSeparator();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("        Press any key to continue...");

            Console.ReadKey(true);

            Console.Clear();

            return;
        }

        if(transferAmount <= 0)
        {
            Console.WriteLine("\n");
            ConsoleUI.ShowSeparator();
            ConsoleUI.ShowError("Invalid transfer amount.");
            ConsoleUI.ShowSeparator();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("        Press any key to continue...");

            Console.ReadKey(true);

            Console.Clear();

            return;
        }

        if(account1.Balance < transferAmount)
        {
            Console.WriteLine("\n");
            ConsoleUI.ShowSeparator();
            ConsoleUI.ShowError("You don't have enough money to make this transfer.");
            ConsoleUI.ShowSeparator();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("        Press any key to continue...");

            Console.ReadKey(true);

            Console.Clear();

            return;
        }


        bool withdrawSuccessful = account1.SubstractTransferMoney(transferAmount);

        if (!withdrawSuccessful)
        {
            Console.WriteLine("\n");
            ConsoleUI.ShowSeparator();
            ConsoleUI.ShowError("Unable to complete the transfer.");
            ConsoleUI.ShowSeparator();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("        Press any key to continue...");

            Console.ReadKey(true);

            Console.Clear();
            return;
        }

        bool depositSuccessful = account2.AddTransferMoney(transferAmount);

        if (!depositSuccessful)
        {
            Console.WriteLine("\n");
            ConsoleUI.ShowSeparator();
            ConsoleUI.ShowError("Unable to complete the transfer.");
            ConsoleUI.ShowSeparator();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("        Press any key to continue...");

            Console.ReadKey(true);

            Console.Clear();
            return;
        }

        Console.Clear();

        ConsoleUI.ShowSeparator();
        ConsoleUI.ShowHeader("             TRANSFER MONEY");
        ConsoleUI.ShowSeparator();
        Console.WriteLine();
        Console.WriteLine($" From Account ID     : {account1.Id}");
        Console.WriteLine($" To Account ID       : {account2.Id}");
        Console.WriteLine($" Amount              : {transferAmount:F2}");
        Console.WriteLine();
        ConsoleUI.ShowSuccess("Money has been transferred successfully.");
        ConsoleUI.ShowSeparator();
        Console.WriteLine();
        Console.WriteLine("        Press any key to continue...");

        Console.ReadKey(true);

        Console.Clear();
    }




    void showMenuAccount()
    {
        ConsoleUI.ShowHeader(" █████╗  ██████╗ ██████╗ ██████╗ ██╗   ██╗███╗   ██╗████████╗");
        ConsoleUI.ShowHeader("██╔══██╗██╔════╝██╔════╝██╔═══██╗██║   ██║████╗  ██║╚══██╔══╝");
        ConsoleUI.ShowHeader("███████║██║     ██║     ██║   ██║██║   ██║██╔██╗ ██║   ██║");
        ConsoleUI.ShowHeader("██╔══██║██║     ██║     ██║   ██║██║   ██║██║╚██╗██║   ██║");
        ConsoleUI.ShowHeader("██║  ██║╚██████╗╚██████╗╚██████╔╝╚██████╔╝██║ ╚████║   ██║");
        ConsoleUI.ShowHeader("╚═╝  ╚═╝ ╚═════╝ ╚═════╝ ╚═════╝  ╚═════╝ ╚═╝  ╚═══╝   ╚═╝");
        ConsoleUI.ShowHeader("███╗   ███╗ █████╗ ███╗   ██╗ █████╗  ██████╗ ███████╗███╗   ███╗███████╗███╗   ██╗████████╗");
        ConsoleUI.ShowHeader("████╗ ████║██╔══██╗████╗  ██║██╔══██╗██╔════╝ ██╔════╝████╗ ████║██╔════╝████╗  ██║╚══██╔══╝");
        ConsoleUI.ShowHeader("██╔████╔██║███████║██╔██╗ ██║███████║██║  ███╗█████╗  ██╔████╔██║█████╗  ██╔██╗ ██║   ██║");
        ConsoleUI.ShowHeader("██║╚██╔╝██║██╔══██║██║╚██╗██║██╔══██║██║   ██║██╔══╝  ██║╚██╔╝██║██╔══╝  ██║╚██╗██║   ██║");
        ConsoleUI.ShowHeader("██║ ╚═╝ ██║██║  ██║██║ ╚████║██║  ██║╚██████╔╝███████╗██║ ╚═╝ ██║███████╗██║ ╚████║   ██║");
        ConsoleUI.ShowHeader("╚═╝     ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝ ╚═════╝ ╚══════╝╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝   ╚═╝");
        ConsoleUI.ShowSeparator();
    }
}