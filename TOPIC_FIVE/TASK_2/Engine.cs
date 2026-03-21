using System;

public class Engine
{
    public int Horsepower { get; set; }

    public Engine(int horsepower)
    {
        Horsepower = horsepower;
        Console.WriteLine($"Двигатель создан с мощностью {Horsepower} л.с.");
    }

    public void Start()
    {
        Console.WriteLine("Двигатель запущен.");
    }

    public void Stop()
    {
        Console.WriteLine("Двигатель остановлен.");
    }
}

