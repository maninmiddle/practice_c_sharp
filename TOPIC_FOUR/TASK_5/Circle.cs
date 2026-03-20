using System;

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double r)
    {
        Radius = r;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Circle: R={Radius}, Area={CalculateArea()}");
    }
}
