using System;

public class Driver
{
    public string Name { get; set; }

    public Driver(string name)
    {
        Name = name;
    }

    public void Drive(Car car)
    {
        Console.WriteLine($"{Name} садится за руль автомобиля {car.Model}...");
        car.StartEngine();
        car.Drive();
        car.StopEngine();
        Console.WriteLine($"{Name} вышел из автомобиля.");
    }
}
