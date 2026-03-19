using System;

public sealed class Car : Transport
{
    public Car(string model, int maxSpeed, double fuelConsumption)
        : base(model, maxSpeed, fuelConsumption)
    {
    }
}
