using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        PrintHeader("Паттерн: Декоратор | Система заказа пиццы");

        IPizza pizza = new BasicPizza();
        PrintOrder("Заказ 1", pizza);

        pizza = new BasicPizza();
        pizza = new CheeseDecorator(pizza);
        PrintOrder("Заказ 2", pizza);

        pizza = new BasicPizza();
        pizza = new CheeseDecorator(pizza);
        pizza = new PepperoniDecorator(pizza);

        pizza = new BasicPizza();
        pizza = new CheeseDecorator(pizza);
        pizza = new PepperoniDecorator(pizza);
        pizza = new VeggieDecorator(pizza);
        PrintOrder("Заказ 4", pizza);

        pizza = new BasicPizza();
        pizza = new CheeseDecorator(pizza);  
        pizza = new CheeseDecorator(pizza);  
        pizza = new VeggieDecorator(pizza);
        PrintOrder("Заказ 5 (двойной сыр)", pizza);

    }


    static void PrintHeader(string title)
    {
        string line = new string('═', 50);
        Console.WriteLine(line);
        Console.WriteLine($"  {title}");
        Console.WriteLine(line);
    }

    static void PrintOrder(string orderName, IPizza pizza)
    {
        Console.WriteLine($"\n  [{orderName}]");
        Console.WriteLine($"  Состав : {pizza.GetDescription()}");
        Console.WriteLine($"  Цена   : {pizza.GetCost():F2} руб.");
        Console.WriteLine(new string('─', 50));
    }
}