public class PdfReport : IReport
{
    public string ReportType => "PDF";

    public void Generate()
    {
        Console.WriteLine("╔══════════════════════════════╗");
        Console.WriteLine("║  [PDF] Генерация отчёта...   ║");
        Console.WriteLine("║  - Формирование страниц      ║");
        Console.WriteLine("║  - Встраивание шрифтов       ║");
        Console.WriteLine("║  - Сжатие данных             ║");
        Console.WriteLine("╚══════════════════════════════╝");
        }

    public void Save(string path)
    {
        Console.WriteLine($"[PDF] Отчёт сохранён: {path}.pdf");
    }
}
