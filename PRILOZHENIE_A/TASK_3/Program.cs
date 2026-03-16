using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Введите значение a: ");
        double a = double.Parse(Console.ReadLine());

        double z1 = Math.Sin(Math.PI / 2 + 3 * a) / (1 - Math.Sin(3 * a - Math.PI));
        double z2 = 1.0 / Math.Tan((5.0 / 4.0) * Math.PI + (3.0 / 2.0) * a);

        Console.WriteLine($"z1 = {z1:F4}");
        Console.WriteLine($"z2 = {z2:F4}");
    }
}