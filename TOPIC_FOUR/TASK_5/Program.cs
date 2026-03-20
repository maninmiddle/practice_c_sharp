using System;

class Program 
{
    public static void Main()
    {
        Shape c = new Circle(3);
        Shape r = new Rectangle(4, 5);
        c.DisplayInfo();
        r.DisplayInfo();
    }
}