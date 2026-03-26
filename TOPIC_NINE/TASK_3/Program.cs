using System;

class Program
{
    static void Main(string[] args)
    {
        string filePath = Path.Combine(Environment.CurrentDirectory, "file.data");

        UserFileReader reader = new UserFileReader(filePath);
        List<User> users = reader.ReadUsers();

        UserProcessor processor = new UserProcessor(users);

        string searchEmail = "olga@example.com";
        User found = processor.FindUserByEmail(searchEmail);

        if (found != null)
            Console.WriteLine($"Найден: {found.Name}, {found.Age}, {found.Email}");
        else
            Console.WriteLine($"Пользователь с email '{searchEmail}' не найден.");
    }
}