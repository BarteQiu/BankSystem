const double Version = 0.1;

Console.WriteLine("========================");
Console.WriteLine($"Bank system v{Version}");
Console.WriteLine("========================");
Console.WriteLine("\n\n\n");

int Choice = 1;

double Money = 1.87;

while(Choice != 0)
{
    Console.WriteLine("=== Select options ===");
    Console.WriteLine("1. Check balance");
    Console.WriteLine("2. Deposit money");
    Console.WriteLine("3. Withdraw money");
    Console.WriteLine("0. Exit");
    Console.WriteLine("========================");
    Choice = int.Parse(Console.ReadLine());

    switch (Choice)
    {
        case 1:
            Console.Clear();
            Console.WriteLine($"Your balance is {Money}$");
            Console.WriteLine("\n\n\n");
            break;

        case 2:
            Console.Clear();
            Console.WriteLine($"How much money do you want to deposit?");
            double Deposit = int.Parse(Console.ReadLine());

            if (Deposit <= 0)
            {
                Console.WriteLine("You cannot deposit negative numbers. Try again.");
                Console.WriteLine("\n\n\n");
                break;
            }
            Money += Deposit;
            Console.WriteLine("Deposit successful.");
            Console.WriteLine("\n\n\n");
            break;

        case 3:
            Console.Clear();
            Console.WriteLine($"How much money do you want to withdraw?");
            double Withdraw = int.Parse(Console.ReadLine());

            if (Withdraw <= 0)
            {
                Console.WriteLine("You cannot withdraw a negative amount. Please try again.");
                Console.WriteLine("\n\n\n");
                break;
            }
            else if (Money < Withdraw)
            {
                Console.WriteLine("You don't have enought money to withdraw");
                Console.WriteLine("\n\n\n");
                break;
            }


            Money -= Withdraw;
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