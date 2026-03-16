using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Введите первое целое число: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Введите второе целое число: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Сумма: {num1 + num2}\n");
    }
}