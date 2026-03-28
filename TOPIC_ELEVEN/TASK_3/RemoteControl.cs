using System;


public class RemoteControl
{
    private readonly Dictionary<string, ICommand> _onCommands;
    private readonly Dictionary<string, ICommand> _offCommands;

    private readonly List<string> _commandHistory;

    public RemoteControl()
    {
        _onCommands      = new Dictionary<string, ICommand>();
        _offCommands     = new Dictionary<string, ICommand>();
        _commandHistory  = new List<string>();
    }

    public void SetCommand(string slot, ICommand onCommand, ICommand offCommand)
    {
        _onCommands[slot]  = onCommand;
        _offCommands[slot] = offCommand;
        Console.WriteLine($"  [Пульт] Слот '{slot}' настроен.");
    }

    public void PressOnButton(string slot)
    {
        if (_onCommands.TryGetValue(slot, out ICommand? command))
        {
            Console.WriteLine($"  [Пульт] Нажата кнопка ВКЛ → слот '{slot}'");
            command.Execute();
            _commandHistory.Add($"ON  [{slot}]");
        }
        else
        {
            Console.WriteLine($"  [Пульт] Слот '{slot}' не настроен!");
        }
    }

    public void PressOffButton(string slot)
    {
        if (_offCommands.TryGetValue(slot, out ICommand? command))
        {
            Console.WriteLine($"  [Пульт] Нажата кнопка ВЫКЛ → слот '{slot}'");
            command.Execute();
            _commandHistory.Add($"OFF [{slot}]");
        }
        else
        {
            Console.WriteLine($"  [Пульт] Слот '{slot}' не настроен!");
        }
    }

    public void PrintHistory()
    {
        Console.WriteLine("\n  [История команд]");
        Console.WriteLine(new string('─', 35));

        if (_commandHistory.Count == 0)
        {
            Console.WriteLine("  История пуста.");
            return;
        }

        for (int i = 0; i < _commandHistory.Count; i++)
        {
            Console.WriteLine($"  {i + 1,2}. {_commandHistory[i]}");
        }
    }
}
