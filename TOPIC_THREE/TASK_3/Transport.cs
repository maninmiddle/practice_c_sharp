using System;


public abstract class Transport
{
    public string Model { get; set; }
    public int MaxSpeed { get; set; }
    public double FuelConsumption { get; set; }

    protected Transport(string model, int maxSpeed, double fuelConsumption)
    {
        Model = model;
        MaxSpeed = maxSpeed;
        FuelConsumption = fuelConsumption;
    }

    public override string ToString()
    {
        return $"Модель: {Model}, Макс. скорость: {MaxSpeed}, Расход топлива: {FuelConsumption}";
    }
}
