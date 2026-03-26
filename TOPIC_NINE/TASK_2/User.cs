using System;

public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }

    public User(string name, int age, string email)
    {
        Name = name;
        Age = age;
        Email = email;
    }

    public string ToFileString()
    {
        return $"{Name},{Age},{Email}";
    }

    public static User FromFileString(string line)
    {
        string[] parts = line.Split(',');
        if (parts.Length == 3 && int.TryParse(parts[1], out int age))
            return new User(parts[0], age, parts[2]);
        return null;
    }
}