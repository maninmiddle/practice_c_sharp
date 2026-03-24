using System; 

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n--- Демонстрация проверки возрастных ограничений для регистрации ---");
        UserRegistration registration = new UserRegistration();

        try
        {
            Console.WriteLine("Попытка регистрации пользователя с возрастом 22 года:");
            registration.RegisterUser(22);

            Console.WriteLine("\nПопытка регистрации пользователя с возрастом 15 лет:");
            registration.RegisterUser(15);
        }
        catch (AgeRestrictionException ex)
        {
            Console.WriteLine($"\nОшибка регистрации: {ex.Message}");
        }
        catch (Exception ex) 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nПроизошла непредвиденная ошибка: {ex.Message}");
            Console.ResetColor();
        }

        Console.WriteLine("\nПрограмма продолжает выполнение после проверки возрастных ограничений.");
    }
}