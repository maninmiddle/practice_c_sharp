using System;

public class Fish : Animal, ICanSwim
{
    public Fish(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} говорит: Буль-буль!");
    }

    public void Swim()
    {
        Console.WriteLine($"{Name} плывёт в воде.");
    }
}

