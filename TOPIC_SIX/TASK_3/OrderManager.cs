using System;

public class OrderManager
{
    public event OrderPlacedEventHandler OrderPlaced;
    
    private static int _orderCounter = 0;
    
    public void PlaceOrder(string customerName, decimal orderAmount, string productName)
    {
        _orderCounter++;
        var orderEventArgs = new OrderEventArgs(_orderCounter, customerName, orderAmount, productName);
        
        Console.WriteLine($"\n📦 [ИЗДАТЕЛЬ] Новый заказ создан: {orderEventArgs}");
        
        OnOrderPlaced(orderEventArgs);
    }
    
    protected virtual void OnOrderPlaced(OrderEventArgs e)
    {
        if (OrderPlaced != null)
        {
            Console.WriteLine($"📢 [ИЗДАТЕЛЬ] Оповещение подписчиков о новом заказе...");
            OrderPlaced(this, e);
        }
        else
        {
            Console.WriteLine($"⚠️ [ИЗДАТЕЛЬ] Нет подписчиков для оповещения");
        }
    }
    
    public void ShowSubscribers()
    {
        if (OrderPlaced != null)
        {
            var subscribers = OrderPlaced.GetInvocationList();
            Console.WriteLine($"\n📋 Активные подписчики ({subscribers.Length}):");
            foreach (var subscriber in subscribers)
            {
                Console.WriteLine($"   - {subscriber.Method.DeclaringType?.Name}.{subscriber.Method.Name}");
            }
        }
        else
        {
            Console.WriteLine("\n📋 Нет активных подписчиков");
        }
    }
}