using System;

public class Wheel
{
    public string TireBrand { get; set; }

    public Wheel(string tireBrand)
    {
        TireBrand = tireBrand;
    }

    public void Rotate()
    {
        Console.WriteLine($"Колесо с брендом {TireBrand} вращается.");
    }
}
