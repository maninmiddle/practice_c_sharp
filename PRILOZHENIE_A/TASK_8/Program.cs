using System;
public class Program
{
    public static void Main()
    {
        double x = 4.3;

        double y = (1 + Math.Sqrt(3 - Math.Pow(x, 2)) / Math.Atan(Math.Pow(x, 2))) - Math.Exp(Math.Sin(Math.Sqrt(x)));

        Console.WriteLine($"x = {x}");
        Console.WriteLine($"y = {y:F4}");
    }
}