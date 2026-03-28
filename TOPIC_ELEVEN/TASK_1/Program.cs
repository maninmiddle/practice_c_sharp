using System;

class Program
{
    static void Main(string[] args)
    {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("═══════════════════════════════════");
            Console.WriteLine("   Паттерн: Фабричный метод        ");
            Console.WriteLine("   Система генерации отчётов       ");
            Console.WriteLine("═══════════════════════════════════");

            var factories = new Dictionary<string, ReportFactory>
            {
                { "PDF",   new PdfReportFactory()   },
                { "Excel", new ExcelReportFactory() },
                { "Word",  new WordReportFactory()  }
            };

            foreach (var (name, factory) in factories)
            {
                string savePath = $"C:/Reports/report_{name.ToLower()}";
                factory.ProcessReport(savePath);
            }

            Console.WriteLine("═══════════════════════════════════");
            Console.WriteLine("Введите тип отчёта (pdf/excel/word):");
            string? input = Console.ReadLine()?.Trim().ToLower();

            ReportFactory? selectedFactory = input switch
            {
                "pdf"   => new PdfReportFactory(),
                "excel" => new ExcelReportFactory(),
                "word"  => new WordReportFactory(),
                _       => null
            };

            if (selectedFactory is not null)
                selectedFactory.ProcessReport($"C:/Reports/custom_{input}");
            else
                Console.WriteLine("Неизвестный тип отчёта.");

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
    }
}
