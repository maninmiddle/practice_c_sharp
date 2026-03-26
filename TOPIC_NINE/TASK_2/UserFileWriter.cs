using System;

public class UserFileWriter
{
    private readonly string _filePath;

    public UserFileWriter(string filePath)
    {
        _filePath = filePath;
    }

    public void WriteUsers(List<User> users)
    {
        using (StreamWriter writer = new StreamWriter(_filePath, false))
        {
            foreach (User user in users)
                writer.WriteLine(user.ToFileString());
        }
        Console.WriteLine($"[OK] Записано пользователей: {users.Count}");
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
        return users;
    }
}