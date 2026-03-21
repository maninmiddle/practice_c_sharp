using System;

public class AudioManager
{
    public static void Run()
    {
        Console.WriteLine("=== Демонстрация явной реализации интерфейсов ===\n");

        AudioDevice device = new AudioDevice("Sony WH-1000XM5");

        device.ShowInfo();
        Console.WriteLine();

        Console.WriteLine("--- Вызов через ISpeaker ---");
        ISpeaker speaker = device;
        speaker.AdjustVolume(50);
        speaker.AdjustVolume(90);
        Console.WriteLine();

        Console.WriteLine("--- Вызов через IMicrophone ---");
        IMicrophone microphone = device;
        microphone.AdjustVolume(30);
        microphone.AdjustVolume(95);
        Console.WriteLine();

        Console.WriteLine("--- Демонстрация приведения типа ---");
        AudioDevice device2 = new AudioDevice("Blue Yeti");
        device2.ShowInfo();

        ((ISpeaker)device2).AdjustVolume(70);

        ((IMicrophone)device2).AdjustVolume(85);

        Console.WriteLine();

        Console.WriteLine("--- Массив аудиоустройств ---");
        AudioDevice[] devices = new AudioDevice[]
        {
            new AudioDevice("JBL Flip 6"),
            new AudioDevice("Bose QC45"),
            new AudioDevice("HyperX QuadCast")
        };

        Console.WriteLine("\nНастройка динамиков всех устройств:");
        foreach (AudioDevice d in devices)
        {
            ISpeaker s = d;
            s.AdjustVolume(60);
        }

        Console.WriteLine("\nНастройка микрофонов всех устройств:");
        foreach (AudioDevice d in devices)
        {
            IMicrophone m = d;
            m.AdjustVolume(45);
        }

        Console.WriteLine("\n=== Конец демонстрации ===");
    }
}