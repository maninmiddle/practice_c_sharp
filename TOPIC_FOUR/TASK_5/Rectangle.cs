using System;

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double w, double h)
    {
        Width = w;
        Height = h;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Rectangle: W={Width}, H={Height}, Area={CalculateArea()}");
    }
}