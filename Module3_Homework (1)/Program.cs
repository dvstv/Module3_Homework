using System;
class Program
{
    static void Main(string[] args)
    {
        Order order = new Order("ноутбук", 2, 50000);
        PriceCalculator calculator = new PriceCalculator();
        double totalPrice = calculator.CalculateTotalPrice(order);
        Console.WriteLine($"итоговая цена: {totalPrice}");
        PaymentProcessor paymentProcessor = new PaymentProcessor();
        paymentProcessor.ProcessPayment("карта 1234-5678");       
        EmailNotifier emailNotifier = new EmailNotifier();
        emailNotifier.SendConfirmationEmail("user@example.com");
    }
}
public class Order
{
    public string productName { get; set; } = string.Empty;
    public int quantity { get; set; }
    public double price { get; set; }
    public Order(string productName, int quantity, double price)
    {
        this.productName = productName;
        this.quantity = quantity;
        this.price = price;
    }
}
public class PriceCalculator
{
    public double CalculateTotalPrice(Order order)
    {
        return order.quantity * order.price * 0.9;
    }
}
public class PaymentProcessor
{
    public void ProcessPayment(string paymentDetails)
    {
        Console.WriteLine("payment processed using: " + paymentDetails);
    }
}
public class EmailNotifier
{
    public void SendConfirmationEmail(string email)
    {
        Console.WriteLine("confirmation email sent to: " + email);
    }
}