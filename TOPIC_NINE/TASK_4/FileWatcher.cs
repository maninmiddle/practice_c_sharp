using System;

public class FileWatcher
{
    private readonly FileSystemWatcher _watcher;

    public FileWatcher(string directory)
    {
        if (!Directory.Exists(directory))
            Directory.CreateDirectory(directory);

        _watcher = new FileSystemWatcher(directory)
        {
            EnableRaisingEvents = true
        };

        _watcher.Created += OnCreated;
        _watcher.Deleted += OnDeleted;
        _watcher.Changed += OnChanged;
        _watcher.Renamed += OnRenamed;
    }

    private void OnCreated(object sender, FileSystemEventArgs e)
    {
        Console.WriteLine($"Файл {e.Name} создан");
    }

    private void OnDeleted(object sender, FileSystemEventArgs e)
    {
        Console.WriteLine($"Файл {e.Name} удален");
    }

    private void OnChanged(object sender, FileSystemEventArgs e)
    {
        Console.WriteLine($"Файл {e.Name} изменен");
    }

    private void OnRenamed(object sender, RenamedEventArgs e)
    {
        Console.WriteLine($"Файл переименован: {e.OldName} -> {e.Name}");
    }

    public void Stop()
    {
        _watcher.EnableRaisingEvents = false;
        _watcher.Dispose();
        Console.WriteLine("Мониторинг остановлен.");
    }
}