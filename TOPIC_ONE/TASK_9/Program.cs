using System;

class Program
{
    static double F(double x)
    {
        return x - Math.Sin(x);
    }

    static void Main()
    {
        double A = 0;
        double B = Math.PI / 2; 
        int M = 10;

        double H = (B - A) / M; 
        double x = A; 

        Console.WriteLine("------------------------------------");
        Console.WriteLine($"|     x      |     F(x) = x-sin(x)   |");
        Console.WriteLine("------------------------------------");

        for (int i = 0; i <= M; i++)
        {
            double y = F(x); 
            Console.WriteLine($"| {x,10:F6} | {y,19:F6} |"); 
            x += H; 
        }

        Console.WriteLine("------------------------------------");
    }
}
