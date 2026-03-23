using System;

public class OrderManager
{
    public event EventHandler<OrderEventArgs> OrderPlaced;
    private static int _orderCounter = 0;
    
    public void PlaceOrder(string customerName, string customerEmail, 
                          string customerPhone, decimal orderAmount, string productName)
    {
        _orderCounter++;
        var args = new OrderEventArgs(_orderCounter, customerName, customerEmail, 
                                      customerPhone, orderAmount, productName);
        
        Console.WriteLine($"Создан заказ #{args.OrderId}: {args.CustomerName}, {args.ProductName}, {args.OrderAmount:C}");
        
        OrderPlaced?.Invoke(this, args);
    }
}