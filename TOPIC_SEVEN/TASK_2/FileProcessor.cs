using System;

public class FileProcessor
{
    private ExternalService _externalService;

    public FileProcessor(ExternalService externalService)
    {
        _externalService = externalService;
    }

    public void ProcessFileWithWrapping()
    {
        try
        {
            Console.WriteLine("Попытка выполнения операции в стороннем сервисе...");
            _externalService.PerformOperationThatMightFail();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Перехвачено исходное исключение: {ex.GetType().Name} - {ex.Message}");

            throw new CustomFileException("Ошибка при обработке файла из-за проблемы во внешнем сервисе.", ex);
        }
    }

    public void LogExceptionDetails(Exception ex)
    {
        Console.WriteLine("\n--- Детали исключения ---");
        Console.WriteLine($"Тип исключения: {ex.GetType().Name}");
        Console.WriteLine($"Сообщение: {ex.Message}");
        Console.WriteLine($"Стек вызовов:\n{ex.StackTrace}");

        if (ex.InnerException != null)
        {
            Console.WriteLine("\n--- Внутреннее исключение (InnerException) ---");
            Console.WriteLine($"Тип: {ex.InnerException.GetType().Name}");
            Console.WriteLine($"Сообщение: {ex.InnerException.Message}");
            Console.WriteLine($"Стек вызовов InnerException:\n{ex.InnerException.StackTrace}");
        }
    }
}