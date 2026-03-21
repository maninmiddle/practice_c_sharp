using System;

public class Intern : Employee
{
    public decimal Stipend { get; set; }

    public Intern(string name, int id, decimal stipend) : base(name, id)
    {
        Stipend = stipend;
    }

    public override decimal CalculateSalary()
    {
        return Stipend;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Должность: Стажер, Зарплата: {CalculateSalary():C}";
    }
}
