using System;

public class WordReport : IReport
{
    public string ReportType => "Word";

    public void Generate()
    {
        Console.WriteLine("╔══════════════════════════════╗");
        Console.WriteLine("║  [Word] Генерация отчёта...  ║");
        Console.WriteLine("║  - Формирование разделов     ║");
        Console.WriteLine("║  - Применение стилей         ║");
        Console.WriteLine("║  - Добавление оглавления     ║");
        Console.WriteLine("╚══════════════════════════════╝");
    }

    public void Save(string path)
    {
        Console.WriteLine($"[Word] Отчёт сохранён: {path}.docx");
    }
}
