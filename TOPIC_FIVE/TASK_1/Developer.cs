using System;

public class Developer : Employee
{
    public decimal HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public Developer(string name, int id, decimal hourlyRate, int hoursWorked) : base(name, id)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }

    public override decimal CalculateSalary()
    {
        return HourlyRate * HoursWorked;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Должность: Разработчик, Зарплата: {CalculateSalary():C}";
    }
}

