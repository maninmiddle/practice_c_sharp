using System;

public class ConsoleLogger
{
    public void LogToConsole(string message)
    {
        Console.WriteLine($"[CONSOLE] {DateTime.Now:HH:mm:ss} - {message}");
    }
}