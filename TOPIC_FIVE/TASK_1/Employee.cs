using System;

public abstract class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }

    public Employee(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public abstract decimal CalculateSalary();

    public override string ToString()
    {
        return $"ID: {Id}, Имя: {Name}";
    }
}

