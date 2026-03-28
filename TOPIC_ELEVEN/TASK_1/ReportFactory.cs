using System;

public abstract class ReportFactory
{
    public abstract IReport CreateReport();

    public void ProcessReport(string savePath)
    {
        IReport report = CreateReport();

        Console.WriteLine($"\n>>> Создан отчёт типа: [{report.ReportType}]");
        Console.WriteLine(new string('─', 34));

        report.Generate();
        report.Save(savePath);

        Console.WriteLine(new string('─', 34));
        Console.WriteLine(">>> Обработка отчёта завершена.\n");
    }
}
