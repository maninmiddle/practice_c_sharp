using System;

public class Car
{
    public string Model { get; set; }
    public Wheel[] Wheels { get; set; } 
    public Engine Engine { get; set; }   
    public Driver Driver { get; set; }  

    public Car(string model, int wheelCount, int engineHorsepower)
    {
        Model = model;
        Engine = new Engine(engineHorsepower); 

        Wheels = new Wheel[wheelCount];
        for (int i = 0; i < wheelCount; i++)
        {
            Wheels[i] = new Wheel($"Brand_{i+1}");
        }
    }

    public void AssignDriver(Driver driver)
    {
        Driver = driver;
    }

    public void StartEngine()
    {
        Engine.Start();
    }

    public void StopEngine()
    {
        Engine.Stop();
    }

    public void Drive()
    {
        Console.WriteLine($"Автомобиль {Model} едет.");
        foreach (var wheel in Wheels)
        {
            wheel.Rotate();
        }
    }
}

