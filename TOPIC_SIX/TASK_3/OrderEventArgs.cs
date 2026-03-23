using System;

public class OrderEventArgs : EventArgs
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public decimal OrderAmount { get; set; }
    public string ProductName { get; set; }
    public DateTime OrderDate { get; set; }
    
    public OrderEventArgs(int orderId, string customerName, decimal orderAmount, string productName)
    {
        OrderId = orderId;
        CustomerName = customerName;
        OrderAmount = orderAmount;
        ProductName = productName;
        OrderDate = DateTime.Now;
    }
    
    public override string ToString()
    {
        return $"Заказ #{OrderId} | Клиент: {CustomerName} | Товар: {ProductName} | Сумма: {OrderAmount:C} | Дата: {OrderDate:dd.MM.yyyy HH:mm}";
    }
}