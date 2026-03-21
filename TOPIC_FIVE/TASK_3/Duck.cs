using System;

public class Duck : Animal, ICanFly, ICanSwim
{
    public Duck(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} говорит: Кря-кря!");
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} летит над озером.");
    }

    public void Swim()
    {
        Console.WriteLine($"{Name} плавает в озере.");
    }
}
