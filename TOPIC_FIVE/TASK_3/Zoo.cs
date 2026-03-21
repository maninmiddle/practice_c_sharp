using System;

public class Zoo
{
    public static void Run()
    {
        Animal[] animals = new Animal[]
        {
            new Bird("Воробей"),
            new Fish("Карп"),
            new Bird("Орёл"),
            new Fish("Щука"),
            new Duck("Утка Дональд"),
            new Bird("Попугай"),
            new Fish("Лосось")
        };

        Console.WriteLine("--- Все животные в зоопарке ---");
        foreach (Animal animal in animals)
        {
            animal.MakeSound();
        }

        Console.WriteLine();

        Console.WriteLine("--- Животные, которые умеют летать ---");
        List<ICanFly> flyingAnimals = new List<ICanFly>();

        foreach (Animal animal in animals)
        {
            if (animal is ICanFly flyer)
            {
                flyingAnimals.Add(flyer);
            }
        }

        foreach (ICanFly flyer in flyingAnimals)
        {
            Animal a = (Animal)flyer;
            Console.Write($"  {a.Name}: ");
            flyer.Fly();
        }

        Console.WriteLine();

        Console.WriteLine("--- Животные, которые умеют плавать ---");
        List<ICanSwim> swimmingAnimals = new List<ICanSwim>();

        foreach (Animal animal in animals)
        {
            if (animal is ICanSwim swimmer)
            {
                swimmingAnimals.Add(swimmer);
            }
        }

        foreach (ICanSwim swimmer in swimmingAnimals)
        {
            Animal a = (Animal)swimmer;
            Console.Write($"  {a.Name}: ");
            swimmer.Swim();
        }

        Console.WriteLine();

        Console.WriteLine("--- Животные, которые умеют и летать, и плавать ---");
        foreach (Animal animal in animals)
        {
            if (animal is ICanFly && animal is ICanSwim)
            {
                Console.WriteLine($"  {animal.Name} умеет и летать, и плавать!");
                ((ICanFly)animal).Fly();
                ((ICanSwim)animal).Swim();
            }
        }

        Console.WriteLine("---------------------------------------");
    }
}