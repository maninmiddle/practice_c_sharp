using System;

public class OrderNotifier
{
    private OrderManager _orderManager;
    private EmailService _emailService;
    private SmsService _smsService;
    
    public OrderNotifier(OrderManager orderManager, EmailService emailService, SmsService smsService)
    {
        _orderManager = orderManager;
        _emailService = emailService;
        _smsService = smsService;
    }
    
    public void SubscribeAll()
    {
        _orderManager.OrderPlaced += _emailService.SendOrderConfirmationEmail;
        _orderManager.OrderPlaced += _smsService.SendOrderConfirmationSms;
        Console.WriteLine("Подписка оформлена: EmailService и SmsService");
    }
    
    public void UnsubscribeAll()
    {
        _orderManager.OrderPlaced -= _emailService.SendOrderConfirmationEmail;
        _orderManager.OrderPlaced -= _smsService.SendOrderConfirmationSms;
        Console.WriteLine("Отписка выполнена");
    }
}