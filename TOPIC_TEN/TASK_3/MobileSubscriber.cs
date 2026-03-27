using System;

public class MobileSubscriber : INewsSubscriber
{
    public string PhoneNumber { get; }

    public MobileSubscriber(string phoneNumber)
    {
        PhoneNumber = phoneNumber;
    }

    public void Update(string news)
    {
        Console.WriteLine($"MobileSubscriber: Sending SMS to {PhoneNumber} with news: '{news}'");
    }
}
