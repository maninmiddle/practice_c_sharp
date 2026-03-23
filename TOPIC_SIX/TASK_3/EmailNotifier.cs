using System;

public class EmailNotifier
{
    private string _emailAddress;
    private string _companyName;
    
    public EmailNotifier(string emailAddress, string companyName = "Online Shop")
    {
        _emailAddress = emailAddress;
        _companyName = companyName;
    }
    
    public void OnOrderPlaced(object sender, OrderEventArgs e)
    {
        Console.WriteLine($"\n📧 [EMAIL] Отправка email на {_emailAddress}...");
        Console.WriteLine($"   От: {_companyName} <noreply@{_companyName.ToLower().Replace(" ", "")}.com>");
        Console.WriteLine($"   Тема: Подтверждение заказа #{e.OrderId}");
        Console.WriteLine($"   Содержание:");
        Console.WriteLine($"     Уважаемый(ая) {e.CustomerName}!");
        Console.WriteLine($"     Ваш заказ #{e.OrderId} успешно оформлен.");
        Console.WriteLine($"     Детали заказа:");
        Console.WriteLine($"       - Товар: {e.ProductName}");
        Console.WriteLine($"       - Сумма: {e.OrderAmount:C}");
        Console.WriteLine($"       - Дата: {e.OrderDate:dd.MM.yyyy HH:mm}");
        Console.WriteLine($"     Спасибо за покупку!");
        Console.WriteLine($"   ✅ Email успешно отправлен");
    }
}