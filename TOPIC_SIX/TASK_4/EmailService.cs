using System;

public class EmailService
{
    public void SendOrderConfirmationEmail(object sender, OrderEventArgs e)
    {
        Console.WriteLine($" Email отправлен на {e.CustomerEmail}: Заказ #{e.OrderId} подтвержден");
    }
}
