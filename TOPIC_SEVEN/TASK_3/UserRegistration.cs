using System;

public class UserRegistration
{
    public void RegisterUser(int age)
    {
        if (age < 18)
        {
            throw new AgeRestrictionException($"Регистрация невозможна. Минимальный возраст: 18 лет. Предоставленный возраст: {age}.");
        }
        Console.WriteLine($"Пользователь с возрастом {age} успешно зарегистрирован.");
    }
}