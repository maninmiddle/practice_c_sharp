using System;

public class VeggieDecorator : PizzaDecorator
{
    private const double VeggieCost = 40.00;

    public VeggieDecorator(IPizza pizza) : base(pizza) { }

    public override string GetDescription()
    {
        return _pizza.GetDescription() + ", овощи";
    }

    public override double GetCost()
    {
        return _pizza.GetCost() + VeggieCost;
    }
}