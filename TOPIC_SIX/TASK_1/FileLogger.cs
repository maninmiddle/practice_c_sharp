using System;

public class FileLogger
{
    private string filePath = "log.txt";
    
    public void LogToFile(string message)
    {
        try
        {
            string logEntry = $"[FILE] {DateTime.Now:HH:mm:ss} - {message}";
            File.AppendAllText(filePath, logEntry + Environment.NewLine);
            Console.WriteLine($"Сообщение записано в файл: {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при записи в файл: {ex.Message}");
        }
    }
}
