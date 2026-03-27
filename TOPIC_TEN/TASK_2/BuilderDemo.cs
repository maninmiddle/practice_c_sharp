using System;

public class BuilderDemo
{
    public static void Run()
    {
        var pdfBuilder = new PDFReportBuilder();
        var director = new ReportDirector(pdfBuilder);
        Report pdfReport = director.BuildFullReport();
        pdfReport.Display();

        var wordBuilder = new WordReportBuilder();
        director.SetBuilder(wordBuilder);
        Report wordReport = director.BuildShortReport();
        wordReport.Display();

        var excelReport = new ExcelReportBuilder()
            .SetTitle("Custom Excel Report")
            .SetHeader("Data Export")
            .SetBody("Raw data for analysis.")
            .AddTable("Sales Data 2024")
            .AddTable("Customer Segments")
            .AddChart("Sales Trend Line")
            .SetFooter("Generated automatically")
            .Build();
        excelReport.Display();
    }
}
