using System.Security.Principal;

bankSystem bankSystem = new bankSystem();
ConsoleUI ConsoleUI = new ConsoleUI();

const string Version = "0.5";

ShowLogo();

string Choice;
bool programIsOn = true;

while (programIsOn)
{
    showMenu();

    Choice = Console.ReadLine();

    if (!int.TryParse(Choice, out int userChoice))
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

        continue;
    }

    switch (userChoice)
    {
        case 1:
            bankSystem.showBalance();
            break;

        case 2:
            bankSystem.depositMoney();
            break;

        case 3:
            bankSystem.withdrawMoney();
            break;

        case 4:
            bankSystem.ShowTransactionHistoryMenu();
            break;

        case 5:
            bankSystem.accounts();
            break;

        case 0:
            Console.Clear();
            showGoodbyeMessage();
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
            break;
    }
}

static void ShowLogo()
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;

    Console.WriteLine("██████╗  █████╗ ███╗   ██╗██╗  ██╗");
    Console.WriteLine("██╔══██╗██╔══██╗████╗  ██║██║ ██╔╝");
    Console.WriteLine("██████╔╝███████║██╔██╗ ██║█████╔╝ ");
    Console.WriteLine("██╔══██╗██╔══██║██║╚██╗██║██╔═██╗ ");
    Console.WriteLine("██████╔╝██║  ██║██║ ╚████║██║  ██╗");
    Console.WriteLine($"╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝ v{Version}");

    Console.WriteLine("\n");
}
void showMenu()
{
    ConsoleUI.ShowHeader("███╗   ███╗ █████╗ ██╗███╗   ██╗");
    ConsoleUI.ShowHeader("████╗ ████║██╔══██╗██║████╗  ██║");
    ConsoleUI.ShowHeader("██╔████╔██║███████║██║██╔██╗ ██║");
    ConsoleUI.ShowHeader("██║╚██╔╝██║██╔══██║██║██║╚██╗██║");
    ConsoleUI.ShowHeader("██║ ╚═╝ ██║██║  ██║██║██║ ╚████║");
    ConsoleUI.ShowHeader("╚═╝     ╚═╝╚═╝  ╚═╝╚═╝╚═╝  ╚═══╝");
    ConsoleUI.ShowHeader("███╗   ███╗███████╗███╗   ██╗██╗   ██╗");
    ConsoleUI.ShowHeader("████╗ ████║██╔════╝████╗  ██║██║   ██║");
    ConsoleUI.ShowHeader("██╔████╔██║█████╗  ██╔██╗ ██║██║   ██║");
    ConsoleUI.ShowHeader("██║╚██╔╝██║██╔══╝  ██║╚██╗██║██║   ██║");
    ConsoleUI.ShowHeader("██║ ╚═╝ ██║███████╗██║ ╚████║╚██████╔╝");
    ConsoleUI.ShowHeader("╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝");

    ConsoleUI.ShowSeparator();

    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("  [1] Check balance");
    Console.WriteLine("  [2] Deposit money");
    Console.WriteLine("  [3] Withdraw money");
    Console.WriteLine("  [4] Transaction history");
    Console.WriteLine("  [5] Account management");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("  [0] Exit");
    Console.ResetColor();
    ConsoleUI.ShowSeparator();

    Console.Write("  Select an option: ");
}
void showGoodbyeMessage()
{
    ConsoleUI.ShowHeader(" ██████╗  ██████╗  ██████╗ ██████╗ ██████╗ ██╗   ██╗███████╗");
    ConsoleUI.ShowHeader("██╔════╝ ██╔═══██╗██╔═══██╗██╔══██╗██╔══██╗╚██╗ ██╔╝██╔════╝");
    ConsoleUI.ShowHeader("██║  ███╗██║   ██║██║   ██║██║  ██║██████╔╝ ╚████╔╝ █████╗");
    ConsoleUI.ShowHeader("██║   ██║██║   ██║██║   ██║██║  ██║██╔══██╗  ╚██╔╝  ██╔══╝");
    ConsoleUI.ShowHeader("╚██████╔╝╚██████╔╝╚██████╔╝██████╔╝██████╔╝   ██║   ███████╗");
    ConsoleUI.ShowHeader(" ╚═════╝  ╚═════╝  ╚═════╝ ╚═════╝ ╚═════╝    ╚═╝   ╚══════╝ \n\n\n");

    ConsoleUI.grayText("------------------------------------------------------------");

    ConsoleUI.ShowHeader("");
    ConsoleUI.ShowHeader("               Thank you for using BankSystem!");
    ConsoleUI.ShowHeader("                  Your session has ended.");
    ConsoleUI.ShowHeader("");
    ConsoleUI.ShowHeader($"                       BankSystem v{Version}");
    ConsoleUI.ShowHeader("");

    ConsoleUI.grayText("------------------------------------------------------------");
    Console.WriteLine("\n\n\n");
}