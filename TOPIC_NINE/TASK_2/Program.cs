using System;

class Program
{
    static void Main(string[] args)
    {
        string filePath = Path.Combine(Environment.CurrentDirectory, "file.data");
        UserFileWriter writer = new UserFileWriter(filePath);

        List<User> users = new List<User>
        {
            new User("Иван", 25, "ivan@example.com"),
            new User("Ольга", 30, "olga@example.com"),
            new User("Петр", 22, "petr@test.net"),
            new User("Анна", 28, "anna@domain.org")
        };

        writer.WriteUsers(users);

        List<User> readUsers = writer.ReadUsers();
        foreach (User user in readUsers)
            Console.WriteLine($"{user.Name}, {user.Age}, {user.Email}");
    }
}