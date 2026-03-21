using System;

public class AudioDevice: IMicrophone, ISpeaker
{
    public string DeviceName { get; set; }

    public AudioDevice(string deviceName)
    {
        DeviceName = deviceName;
    }

    void ISpeaker.AdjustVolume(int level)
    {
        Console.WriteLine($"[{DeviceName}] Динамик: громкость установлена на уровень {level}.");
        if (level > 80)
        {
            Console.WriteLine($"  ⚠ Внимание: высокая громкость динамика может повредить слух!");
        }
    }

    void IMicrophone.AdjustVolume(int level)
    {
        Console.WriteLine($"[{DeviceName}] Микрофон: чувствительность установлена на уровень {level}.");
        if (level > 90)
        {
            Console.WriteLine($"  ⚠ Внимание: высокая чувствительность микрофона может вызвать обратную связь!");
        }
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Аудиоустройство: {DeviceName}");
    }
}

