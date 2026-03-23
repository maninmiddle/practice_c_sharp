using System;

public class OrderEventArgs : EventArgs
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public string CustomerPhone { get; set; }
    public decimal OrderAmount { get; set; }
    public string ProductName { get; set; }
    
    public OrderEventArgs(int orderId, string customerName, string customerEmail, 
                          string customerPhone, decimal orderAmount, string productName)
    {
        OrderId = orderId;
        CustomerName = customerName;
        CustomerEmail = customerEmail;
        CustomerPhone = customerPhone;
        OrderAmount = orderAmount;
        ProductName = productName;
    }
}