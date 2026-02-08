using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<INotificationSender> senders = new List<INotificationSender>
        {
            new EmailSender(),
            new SmsSender(),
            new MessengerSender()
        };
        NotificationService service = new NotificationService(senders);
        service.SendNotification("важное уведомление");
    }
}
public interface INotificationSender
{
    void Send(string message);
}
public class EmailSender : INotificationSender
{
    public void Send(string message)
    {
        Console.WriteLine("email sent: " + message);
    }
}
public class SmsSender : INotificationSender
{
    public void Send(string message)
    {
        Console.WriteLine("sms sent: " + message);
    }
}
public class MessengerSender : INotificationSender
{
    public void Send(string message)
    {
        Console.WriteLine("messenger sent: " + message);
    }
}
public class NotificationService
{
    private List<INotificationSender> senders;
    public NotificationService(List<INotificationSender> senders)
    {
        this.senders = senders;
    }
    public void SendNotification(string message)
    {
        foreach (INotificationSender sender in senders)
        {
            sender.Send(message);
        }
    }
}