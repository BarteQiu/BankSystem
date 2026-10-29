class ConsoleUI
{
    public void ShowHeader(string message)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public void ShowSuccess(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($" [SUCCESS] {message}");
        Console.ResetColor();
    }

    public void ShowError(string message)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($" [ERROR] {message}");
        Console.ResetColor();
    }

    public void ShowInfo(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($" [INFO] {message}");
        Console.ResetColor();
    }

    public void ShowSeparator()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("----------------------------------------");
        Console.ResetColor();
    }





    public void greenText(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(message);
        Console.ResetColor();
    }

    public void redText(string message)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write(message);
        Console.ResetColor();
    }

    public void grayText(string message)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(message);
        Console.ResetColor();
    }

    public void whiteText(string message)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(message);
        Console.ResetColor();
    }

}
