using System;

class Program
{
    public static void Main()
    {
        ConsoleLogger consoleLogger = new ConsoleLogger();
        FileLogger fileLogger = new FileLogger();
        
        Console.WriteLine("=== Демонстрация работы с делегатом MessageHandler ===\n");
        
        Console.WriteLine("1. Использование делегата для консольного логгера:");
        MessageHandler consoleHandler = consoleLogger.LogToConsole;
        consoleHandler("Первое сообщение в консоль");
        consoleHandler("Второе сообщение в консоль");
        
        Console.WriteLine("\n2. Использование делегата для файлового логгера:");
        MessageHandler fileHandler = fileLogger.LogToFile;
        fileHandler("Первое сообщение в файл");
        fileHandler("Второе сообщение в файл");
        
        Console.WriteLine("\n3. Комбинированный делегат (оба логгера):");
        MessageHandler combinedHandler = consoleLogger.LogToConsole;
        combinedHandler += fileLogger.LogToFile;
        
        combinedHandler("Комбинированное сообщение - отправляется и в консоль, и в файл");
        
        Console.WriteLine("\n4. Удаление файлового логгера из комбинации:");
        combinedHandler -= fileLogger.LogToFile;
        combinedHandler("Это сообщение пойдет только в консоль");
        
        Console.WriteLine("\n5. Использование делегата как параметра метода:");
        ProcessMessage(consoleLogger.LogToConsole, "Сообщение через параметр метода");
        ProcessMessage(fileLogger.LogToFile, "Еще одно сообщение через параметр метода");
        
        Console.WriteLine("\n6. Проверка делегата на null:");
        MessageHandler emptyHandler = null;
        
        if (emptyHandler != null)
        {
            emptyHandler("Это сообщение не будет отправлено");
        }
        else
        {
            Console.WriteLine("Делегат пуст, вызов не выполнен");
        }
    }
    
    static void ProcessMessage(MessageHandler handler, string message)
    {
        if (handler != null)
        {
            Console.WriteLine($"Обработка сообщения через метод ProcessMessage:");
            handler(message);
        }
        else
        {
            Console.WriteLine("Обработчик не установлен");
        }
    }
}