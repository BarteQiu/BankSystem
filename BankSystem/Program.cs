bankSystem bankSystem = new bankSystem();

const string Version = "0.3";

Console.WriteLine("========================");
Console.WriteLine($"Bank system v{Version}");
Console.WriteLine("========================");
Console.WriteLine("\n\n\n");

string Choice;

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
            bankSystem.showBalance();
            break;

        case 2:
            bankSystem.depositMoney();
            break;

        case 3:
            bankSystem.withdrawMoney();
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



