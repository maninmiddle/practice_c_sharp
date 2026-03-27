using System;

public class NewsPublisher
{
    private readonly List<INewsSubscriber> _subscribers = new List<INewsSubscriber>();

    public void Subscribe(INewsSubscriber subscriber)
    {
        if (!_subscribers.Contains(subscriber))
        {
            _subscribers.Add(subscriber);
            Console.WriteLine($"Publisher: New subscriber added.");
        }
    }

    public void Unsubscribe(INewsSubscriber subscriber)
    {
        if (_subscribers.Remove(subscriber))
        {
            Console.WriteLine($"Publisher: Subscriber removed.");
        }
    }

    public void PublishNews(string news)
    {
        Console.WriteLine($"\nPublisher: Broadcasting news: '{news}'");
        Console.WriteLine("-------------------------------------");
        foreach (var subscriber in _subscribers)
        {
            // Уведомляем каждого подписчика
            subscriber.Update(news);
        }
        Console.WriteLine("-------------------------------------");
    }
}
