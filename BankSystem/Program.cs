const string Version = "0.1.2";

Console.WriteLine("========================");
Console.WriteLine($"Bank system v{Version}");
Console.WriteLine("========================");
Console.WriteLine("\n\n\n");

string Choice;
double Money = 1.87;

bool isOn = true;

while(isOn == true)
{
    Console.WriteLine("=== Select options ===");
    Console.WriteLine("1. Check balance");
    Console.WriteLine("2. Deposit money");
    Console.WriteLine("3. Withdraw money");
    Console.WriteLine("0. Exit");
    Console.WriteLine("========================");
    Choice = Console.ReadLine();

    if (int.TryParse(Choice, out int userChoice))
    {
        switch (userChoice)
        {
            case 1:
                Console.Clear();
                Console.WriteLine($"Your balance is {Math.Round(Money, 2)}$");
                Console.WriteLine("\n\n\n");
                break;

            case 2:
                Console.Clear();
                Console.WriteLine($"How much money do you want to deposit?");

                string Deposit = Console.ReadLine();

                if (!double.TryParse(Deposit, out double userDeposit))
                {
                    Console.WriteLine("Invalid amount. Please enter a number.");
                    Console.WriteLine("\n\n\n");
                    break;
                }

                if (userDeposit <= 0)
                {
                    Console.WriteLine("You cannot deposit negative numbers. Try again.");
                    Console.WriteLine("\n\n\n");
                    break;
                }

                Money += userDeposit;
                Console.WriteLine("Deposit successful.");
                Console.WriteLine("\n\n\n");
                break;

            case 3:
                Console.Clear();
                Console.WriteLine($"How much money do you want to withdraw?");

                string Withdraw = Console.ReadLine();

                if(!double.TryParse(Withdraw, out double userWithdraw))
                {
                    Console.WriteLine("Invalid amount. Please enter a number.");
                    Console.WriteLine("\n\n\n");
                    break;
                }

                if (userWithdraw <= 0)
                {
                    Console.WriteLine("You cannot withdraw a negative amount. Please try again.");
                    Console.WriteLine("\n\n\n");
                    break;
                }

                if (Money < userWithdraw)
                {
                    Console.WriteLine("You don't have enought money to withdraw");
                    Console.WriteLine("\n\n\n");
                    break;
                }

                Money -= userWithdraw;
                Console.WriteLine("Withdraw successful.");
                Console.WriteLine("\n\n\n");
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
    else
    {
        Console.Clear();
        Console.WriteLine("Please enter a number.");
        Console.WriteLine("\n\n\n");
    }
}