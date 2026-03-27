public class EmailSubscriber : INewsSubscriber
{
    public string EmailAddress { get; }

    public EmailSubscriber(string emailAddress)
    {
        EmailAddress = emailAddress;
    }

    public void Update(string news)
    {
        Console.WriteLine($"EmailSubscriber: Sending email to {EmailAddress} with news: '{news}'");
    }
}

