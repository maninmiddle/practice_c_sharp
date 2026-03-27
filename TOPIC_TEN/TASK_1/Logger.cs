using System;

public sealed class Logger
{
    private static Logger _instance;
    private static readonly object _lock = new object();
    private List<string> _logs;

    private Logger()
    {
        _logs = new List<string>();
    }

    public static Logger Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }
                return _instance;
            }
        }
    }

    public void Log(string message)
    {
        _logs.Add($"{DateTime.Now}: {message}");
    }

    public void ShowLogs()
    {
        Console.WriteLine("--- Application Logs ---");
        if (_logs.Count == 0)
        {
            Console.WriteLine("No logs yet.");
        }
        else
        {
            foreach (var log in _logs)
            {
                Console.WriteLine(log);
            }
        }
        Console.WriteLine("------------------------");
    }
}
