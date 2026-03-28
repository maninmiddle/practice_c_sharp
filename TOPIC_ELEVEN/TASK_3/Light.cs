using System;

public class Light
{
    private readonly string _location;
    private bool _isOn;

    public Light(string location)
    {
        _location = location;
        _isOn = false;
    }

    public void TurnOn()
    {
        _isOn = true;
        Console.WriteLine($"  [Свет] {_location}: ВКЛЮЧЁН  ✓");
    }

    public void TurnOff()
    {
        _isOn = false;
        Console.WriteLine($"  [Свет] {_location}: ВЫКЛЮЧЕН ✗");
    }

    public bool IsOn => _isOn;

    public string GetStatus()
    {
        return $"{_location}: {(_isOn ? "включён ✓" : "выключен ✗")}";
    }
}
