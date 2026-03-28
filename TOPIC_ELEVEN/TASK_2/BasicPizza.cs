using System;

public class BasicPizza : IPizza
{
    public string GetDescription()
    {
        return "Базовая пицца";
    }

    public double GetCost()
    {
        return 200.00;
    }
}