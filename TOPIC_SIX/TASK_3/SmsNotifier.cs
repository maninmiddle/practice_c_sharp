using System;

public class SmsNotifier
{
    private string _phoneNumber;
    private string _smsService;
    
    public SmsNotifier(string phoneNumber, string smsService = "Twilio")
    {
        _phoneNumber = phoneNumber;
        _smsService = smsService;
    }
    
    public void OnOrderPlaced(object sender, OrderEventArgs e)
    {
        Console.WriteLine($"\n📱 [SMS] Отправка SMS через {_smsService} на номер {_phoneNumber}...");
        Console.WriteLine($"   Текст сообщения:");
        Console.WriteLine($"     {e.CustomerName}, ваш заказ #{e.OrderId} на сумму {e.OrderAmount:C} оформлен!");
        Console.WriteLine($"     Товар: {e.ProductName}");
        Console.WriteLine($"     Спасибо за покупку!");
        Console.WriteLine($"   ✅ SMS успешно отправлено");
    }
}