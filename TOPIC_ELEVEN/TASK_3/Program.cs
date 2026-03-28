using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        PrintHeader("Паттерн: Команда | Умный дом — Управление освещением");

        Light livingRoomLight = new Light("Гостиная");
        Light bedroomLight    = new Light("Спальня");
        Light kitchenLight    = new Light("Кухня");

        ICommand livingRoomOn  = new LightOnCommand(livingRoomLight);
        ICommand livingRoomOff = new LightOffCommand(livingRoomLight);

        ICommand bedroomOn     = new LightOnCommand(bedroomLight);
        ICommand bedroomOff    = new LightOffCommand(bedroomLight);

        ICommand kitchenOn     = new LightOnCommand(kitchenLight);
        ICommand kitchenOff    = new LightOffCommand(kitchenLight);

        RemoteControl remote = new RemoteControl();

        Console.WriteLine("\n  Настройка пульта:");
        Console.WriteLine(new string('─', 45));
        remote.SetCommand("Гостиная", livingRoomOn, livingRoomOff);
        remote.SetCommand("Спальня",  bedroomOn,    bedroomOff);
        remote.SetCommand("Кухня",    kitchenOn,    kitchenOff);


        PrintSection("Сценарий 1: Приход домой — включаем свет");
        remote.PressOnButton("Прихожая");   
        remote.PressOnButton("Гостиная");
        remote.PressOnButton("Кухня");

        PrintSection("Сценарий 2: Ужин — свет в гостиной не нужен");
        remote.PressOffButton("Гостиная");

        PrintSection("Сценарий 3: Отход ко сну — включаем спальню, гасим всё");
        remote.PressOnButton("Спальня");
        remote.PressOffButton("Кухня");
        remote.PressOffButton("Спальня");

        PrintSection("Текущий статус устройств");
        Console.WriteLine($"  {livingRoomLight.GetStatus()}");
        Console.WriteLine($"  {bedroomLight.GetStatus()}");
        Console.WriteLine($"  {kitchenLight.GetStatus()}");

        remote.PrintHistory();
    }

    static void PrintHeader(string title)
    {
        string line = new string('═', 55);
        Console.WriteLine(line);
        Console.WriteLine($"  {title}");
        Console.WriteLine(line);
    }

    static void PrintSection(string title)
    {
        Console.WriteLine($"\n  ► {title}");
        Console.WriteLine(new string('─', 45));
    }
}
