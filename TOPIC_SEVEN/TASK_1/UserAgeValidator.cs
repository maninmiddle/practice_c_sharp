using System;

public class UserAgeValidator
{
    public void ValidateAge(int age)
    {
        if (age < 18)
        {
            throw new InvalidAgeException($"Возраст должен быть 18 лет или старше. Текущий возраст: {age}");
        }
        Console.WriteLine($"Возраст {age} действителен.");
    }
}