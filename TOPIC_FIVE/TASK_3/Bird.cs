using System;

public class Bird : Animal, ICanFly
{
    public Bird(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} говорит: Чик-чирик!");
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} летит по небу.");
    }
}
