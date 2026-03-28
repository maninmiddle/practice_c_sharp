using System;

public class CheeseDecorator : PizzaDecorator
{
    private const double CheeseCost = 50.00;

    public CheeseDecorator(IPizza pizza) : base(pizza) { }

    public override string GetDescription()
    {
        return _pizza.GetDescription() + ", сыр";
    }

    public override double GetCost()
    {
        return _pizza.GetCost() + CheeseCost;
    }
}