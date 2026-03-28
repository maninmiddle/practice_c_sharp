using System;

public class ExcelReport : IReport
{
    public string ReportType => "Excel";

    public void Generate()
    {
        Console.WriteLine("╔══════════════════════════════╗");
        Console.WriteLine("║  [Excel] Генерация отчёта... ║");
        Console.WriteLine("║  - Создание таблиц           ║");
        Console.WriteLine("║  - Применение формул         ║");
        Console.WriteLine("║  - Построение диаграмм       ║");
        Console.WriteLine("╚══════════════════════════════╝");
    }

    public void Save(string path)
    {
        Console.WriteLine($"[Excel] Отчёт сохранён: {path}.xlsx");
    }
}
