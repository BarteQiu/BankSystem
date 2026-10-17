const string Version = "0.2";

Console.WriteLine("========================");
Console.WriteLine($"Bank system v{Version}");
Console.WriteLine("========================");
Console.WriteLine("\n\n\n");

string Choice;
decimal Money = 1.87m;

bool programIsOn = true;

while(programIsOn)
{
    showMenu();

    Choice = Console.ReadLine();

    if (!int.TryParse(Choice, out int userChoice))
    {
        Console.Clear();
        Console.WriteLine("Please enter a valid number.");
        Console.WriteLine("\n\n\n");
        continue;
    }

    switch (userChoice)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("\n");
            showBalance();
            break;

        case 2:
            depositMoney();
            break;

        case 3:
            withdrawMoney();
            break;

        case 0:
            Console.Clear();
            Console.WriteLine("Goodbye.");
            return;

        default:
            Console.Clear();
            Console.WriteLine("Wrong option. Try again.");
            Console.WriteLine("\n\n\n");
            break;
    }
}

void showMenu()
{
    Console.WriteLine("=== Select options ===");
    Console.WriteLine("1. Check balance");
    Console.WriteLine("2. Deposit money");
    Console.WriteLine("3. Withdraw money");
    Console.WriteLine("0. Exit");
    Console.WriteLine("========================");
}

void showBalance()
{
    Console.WriteLine($"Your balance is {Money:F2}$");
    Console.WriteLine("\n\n\n");
}

void depositMoney()
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

    Money += userDeposit;
    Console.WriteLine("Deposit successful.");
    Console.WriteLine("\n");
    showBalance();
    Console.WriteLine("\n\n\n");
}

void withdrawMoney()
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

    if (Money < userWithdraw)
    {
        Console.WriteLine("You don't have enough money to withdraw");
        Console.WriteLine("\n\n\n");
        return;
    }

    Money -= userWithdraw;
    Console.WriteLine("Withdraw successful.");
    Console.WriteLine("\n");
    showBalance();
    Console.WriteLine("\n\n\n");
}