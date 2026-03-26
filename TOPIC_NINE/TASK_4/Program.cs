using System;

class Program
{
    static void Main(string[] args)
    {
        string watchDir = Path.Combine(Environment.CurrentDirectory, "WatchFolder");

        FileWatcher watcher = new FileWatcher(watchDir);

        Console.WriteLine($"Мониторинг папки: {watchDir}");
        Console.WriteLine("Создавайте/удаляйте файлы в этой папке.");
        Console.WriteLine("Нажмите любую клавишу для выхода.\n");

        Console.ReadKey();
        watcher.Stop();
    }
}