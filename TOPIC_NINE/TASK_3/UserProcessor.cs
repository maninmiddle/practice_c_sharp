using System;

public class UserProcessor
{
    private readonly List<User> _users;

    public UserProcessor(List<User> users)
    {
        _users = users;
    }

    public User FindUserByEmail(string email)
    {
        return _users.FirstOrDefault(u =>
            u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
    }
}