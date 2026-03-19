using System;

public class ClassA
{
    private int a;
    private int b;

    public ClassA(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public int GetSum()
    {
        return a + b;
    }

    public double GetExpressionValue()
    {
        if (a == 0)
            throw new DivideByZeroException("Значение a не должно быть равно 0.");

        return Math.Sin(b) / (3.0 * a);
    }

    public void Show()
    {
        Console.WriteLine($"a = {a}, b = {b}");
        Console.WriteLine($"Сумма a + b = {GetSum()}");
        Console.WriteLine($"(sin b) / (3a) = {GetExpressionValue():F4}");
    }
}
