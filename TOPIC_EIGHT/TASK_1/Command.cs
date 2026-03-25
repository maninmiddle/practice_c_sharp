using System;

public class Command
{
    public string Description { get; set; }

    public Command(string description)
    {
        Description = description;
    }

    public void Execute()
    {
        Console.WriteLine($"Выполнена команда: {Description}");
    }

    public void Undo()
    {
        Console.WriteLine($"Отменена команда: {Description}");
    }
}