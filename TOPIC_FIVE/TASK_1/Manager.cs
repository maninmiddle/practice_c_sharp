using System;

public class Manager : Employee
{
    public decimal BaseSalary { get; set; }
    public decimal Bonus { get; set; }

    public Manager(string name, int id, decimal baseSalary, decimal bonus) : base(name, id)
    {
        BaseSalary = baseSalary;
        Bonus = bonus;
    }

    public override decimal CalculateSalary()
    {
        return BaseSalary + Bonus;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Должность: Менеджер, Зарплата: {CalculateSalary():C}";
    }
}
