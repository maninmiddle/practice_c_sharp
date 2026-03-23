using System;

public class SmsService
{
    public void SendOrderConfirmationSms(object sender, OrderEventArgs e)
    {
        Console.WriteLine($" SMS отправлен на {e.CustomerPhone}: Заказ #{e.OrderId} подтвержден");
    }
}