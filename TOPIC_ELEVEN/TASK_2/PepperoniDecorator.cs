using System;

public class PepperoniDecorator : PizzaDecorator
{
    private const double PepperoniCost = 75.00;

    public PepperoniDecorator(IPizza pizza) : base(pizza) { }

    public override string GetDescription()
    {
        return _pizza.GetDescription() + ", пепперони";
    }

    public override double GetCost()
    {
        return _pizza.GetCost() + PepperoniCost;
    }
}