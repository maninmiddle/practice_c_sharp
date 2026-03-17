using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите коэффициент A: ");
        double A = double.Parse(Console.ReadLine());
        Console.Write("Введите коэффициент B: ");
        double B = double.Parse(Console.ReadLine());
        Console.Write("Введите коэффициент C: ");
        double C = double.Parse(Console.ReadLine());

        double discriminant = B * B - 4 * A * C;

        if (discriminant >= 0)
            Console.WriteLine("Высказывание ИСТИННО: уравнение имеет вещественные корни.");
        else
            Console.WriteLine("Высказывание ЛОЖНО: уравнение не имеет вещественных корней.");
    }
}
