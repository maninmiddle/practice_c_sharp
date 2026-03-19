using System;

public sealed class Truck : Transport
{
    public Truck(string model, int maxSpeed, double fuelConsumption)
        : base(model, maxSpeed, fuelConsumption)
    {
    }
}
