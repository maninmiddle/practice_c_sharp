using System;

abstract class Shape
{
    public abstract double CalculateArea();
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Shape");
    }
}
