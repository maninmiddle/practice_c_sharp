using System;

public class Program
{
    public static void Main(string[] args)
    {
        ExternalService service = new ExternalService();
        FileProcessor fileProcessor = new FileProcessor(service);

        try
        {
            fileProcessor.ProcessFileWithWrapping();
        }
        catch (CustomFileException ex)
        {
            Console.WriteLine($"\nПерехвачено пользовательское исключение при обработке файла: {ex.Message}");

            fileProcessor.LogExceptionDetails(ex);
        }
        catch (Exception ex) 
        {
            Console.WriteLine($"\nПерехвачено другое неожиданное исключение: {ex.Message}");
        }

        Console.WriteLine("\nПрограмма продолжает выполнение после обработки обернутого исключения.");
    }
}