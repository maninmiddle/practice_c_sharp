using System;

public class EmployeeSystem
{
    public static void Run()
    {
        Employee[] employees = new Employee[]
        {
            new Manager("Иван Петров", 1, 50000, 10000),
            new Developer("Мария Сидорова", 2, 150, 160),
            new Intern("Алексей Иванов", 3, 20000),
            new Manager("Елена Кузнецова", 4, 60000, 15000),
            new Developer("Дмитрий Смирнов", 5, 180, 150)
        };

        Console.WriteLine("--- Список сотрудников и их зарплаты ---");
        foreach (Employee emp in employees)
        {
            Console.WriteLine(emp.ToString());
        }
        Console.WriteLine("---------------------------------------");
    }
}