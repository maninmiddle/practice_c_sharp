using System;

class Program
{
    static void Main(string[] args)
    {
        var orderManager = new OrderManager();
        var emailService = new EmailService();
        var smsService = new SmsService();
        var notifier = new OrderNotifier(orderManager, emailService, smsService);
        
        notifier.SubscribeAll();
        
        orderManager.PlaceOrder("Иван Петров", "ivan@mail.ru", "+79991234567", 1250.50m, "Ноутбук");
        orderManager.PlaceOrder("Мария Сидорова", "maria@mail.ru", "+79992345678", 789.99m, "Смартфон");
        
        notifier.UnsubscribeAll();
        
        orderManager.PlaceOrder("Алексей Иванов", "alex@mail.ru", "+79993456789", 2450.00m, "Консоль");
    }
}