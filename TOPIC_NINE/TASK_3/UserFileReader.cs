using System;

public class UserFileReader
{
    private readonly string _filePath;

    public UserFileReader(string filePath)
    {
        _filePath = filePath;
    }

    public List<User> ReadUsers()
    {
        List<User> users = new List<User>();
        if (!File.Exists(_filePath))
        {
            Console.WriteLine($"[WARN] Файл не найден: {_filePath}");
            return users;
        }
        using (StreamReader reader = new StreamReader(_filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                User user = User.FromFileString(line);
                if (user != null)
                    users.Add(user);
            }
        }
        Console.WriteLine($"[OK] Прочитано пользователей: {users.Count}");
        return users;
    }
}