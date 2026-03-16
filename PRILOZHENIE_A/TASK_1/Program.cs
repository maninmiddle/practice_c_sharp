using System;

public class Program
{
    public static void Main() 
    {
        Console.Write("Введите Радиус (см): ");
        if (double.TryParse(Console.ReadLine(), out double r))
        {
            double circleArea = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Площадь круга: {circleArea:F2} кв.см.");
        }
    }
}