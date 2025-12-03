namespace LAB9;

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
    }

    public void LogError(string message)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
    }
}