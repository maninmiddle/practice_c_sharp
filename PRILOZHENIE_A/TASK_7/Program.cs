using System;
public class Program
{
    public static void Main()
    {
        Console.Write("x1 = ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("y1 = ");
        double y1 = double.Parse(Console.ReadLine());
        Console.Write("x2 = ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("y2 = ");
        double y2 = double.Parse(Console.ReadLine());

        double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine($"Расстояние = {d:F4}");
 
    }
}