using System;

class Program
{
    public static void Main()
    {
        UserAgeValidator validator = new UserAgeValidator();
        try
        {
            Console.WriteLine("\nПопытка проверить действительный возраст:");
            validator.ValidateAge(25);

            Console.WriteLine("\nПопытка проверить недействительный возраст:");
            validator.ValidateAge(16);
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine($"\nОшибка валидации возраста: {ex.Message}");
        }
    }
}