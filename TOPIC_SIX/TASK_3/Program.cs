using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Паттерн Издатель-Подписчик: Оповещение о новом заказе ===\n");
        
        var orderManager = new OrderManager();
        
        var emailNotifier = new EmailNotifier("customer@example.com", "SuperShop");
        var smsNotifier = new SmsNotifier("+7 (999) 123-45-67", "SMSGateway");
        
        Console.WriteLine(new string('=', 60));
        
        orderManager.ShowSubscribers();
        
        orderManager.OrderPlaced += emailNotifier.OnOrderPlaced;
        Console.WriteLine("\n✅ EmailNotifier подписался на событие");
        
        orderManager.ShowSubscribers();
        
        orderManager.OrderPlaced += smsNotifier.OnOrderPlaced;
        Console.WriteLine("\n✅ SmsNotifier подписался на событие");
        
        orderManager.ShowSubscribers();
        
        
        orderManager.ShowSubscribers();
        
        Console.WriteLine(new string('=', 60));
        
        orderManager.PlaceOrder("Иван Петров", 1250.50m, "Ноутбук Lenovo");
        
        orderManager.PlaceOrder("Мария Сидорова", 789.99m, "Смартфон Xiaomi");
        
        orderManager.PlaceOrder("Алексей Иванов", 2450.00m, "Игровая консоль PlayStation 5");
        
        Console.WriteLine(new string('=', 60));
        
        orderManager.OrderPlaced -= smsNotifier.OnOrderPlaced;
        Console.WriteLine("\n❌ SmsNotifier отписался от события");
        
        orderManager.ShowSubscribers();
        
        Console.WriteLine("\n📦 Размещаем заказ после отписки SMS:");
        orderManager.PlaceOrder("Ольга Николаева", 550.75m, "Наушники Sony");
        
        
        var tempNotifier = new EmailNotifier("temp@example.com");
        orderManager.OrderPlaced -= tempNotifier.OnOrderPlaced;
        
        EventHandler<OrderEventArgs> tempHandler = (sender, e) =>
        {
            Console.WriteLine($"\n🔄 [ВРЕМЕННЫЙ] Получено уведомление о заказе #{e.OrderId}");
        };
        
        orderManager.OrderPlaced += (sender, e) => tempHandler(sender, e);
        
        orderManager.PlaceOrder("Сергей Козлов", 3450.00m, "Телевизор Samsung");
        
        orderManager.OrderPlaced -= (sender, e) => tempHandler(sender, e);
        
    }
}