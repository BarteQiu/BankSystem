public static class ConsoleInput
{
    public static bool TryReadInt(string prompt, out int value)
    {
        Console.Write(prompt);
        string input = Console.ReadLine();

        return int.TryParse(input, out value);
    }

    public static bool TryReadDecimal(string prompt, out decimal value)
    {
        Console.Write(prompt);
        string input = Console.ReadLine();

        return decimal.TryParse(input, out value);
    }
}