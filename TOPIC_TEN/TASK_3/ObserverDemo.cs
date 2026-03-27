public class ObserverDemo
{
    public static void Run()
    {
        var publisher = new NewsPublisher();

        var emailSubscriber1 = new EmailSubscriber("user1@example.com");
        var emailSubscriber2 = new EmailSubscriber("user2@example.com");
        var mobileSubscriber1 = new MobileSubscriber("+1234567890");

        publisher.Subscribe(emailSubscriber1);
        publisher.Subscribe(emailSubscriber2);
        publisher.Subscribe(mobileSubscriber1);

        publisher.PublishNews("Important announcement: System maintenance tomorrow.");

        publisher.Unsubscribe(emailSubscriber2);

        publisher.PublishNews("Breaking News: New product launch scheduled.");

        publisher.Subscribe(emailSubscriber1); // Выведет сообщение, что подписчик уже добавлен
    }
}
