using System;
public class Program
{
    public static void Main()
    {
        double x = 3.5;

        double y = Math.Pow(Math.Cos(x), 2) - (Math.Sqrt(Math.Pow(x, 3)) + 1) / Math.Sin(x) + Math.Exp(Math.Log(2 * x));

        Console.WriteLine($"x = {x}");
        Console.WriteLine($"y = {y:F4}");

    }
}