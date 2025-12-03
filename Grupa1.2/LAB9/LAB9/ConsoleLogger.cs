namespace LAB9;

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}