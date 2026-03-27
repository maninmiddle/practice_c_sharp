using System;

public class PDFReportBuilder : IReportBuilder
{
    private Report _report = new Report();

    public PDFReportBuilder()
    {
        _report.Format = "PDF";
    }

    public IReportBuilder SetTitle(string title)
    {
        _report.Title = $"[PDF] {title}";
        return this;
    }

    public IReportBuilder SetHeader(string header)
    {
        _report.Header = $"[PDF Header] {header}";
        return this;
    }

    public IReportBuilder SetBody(string body)
    {
        _report.Body = $"[PDF Body] {body}";
        return this;
    }

    public IReportBuilder AddTable(string tableDescription)
    {
        _report.Tables.Add($"[PDF Table] {tableDescription}");
        return this;
    }

    public IReportBuilder AddChart(string chartDescription)
    {
        _report.Charts.Add($"[PDF Chart] {chartDescription}");
        return this;
    }

    public IReportBuilder SetFooter(string footer)
    {
        _report.Footer = $"[PDF Footer] {footer}";
        return this;
    }

    public Report Build()
    {
        Report result = _report;
        _report = new Report { Format = "PDF" }; // сброс для повторного использования
        return result;
    }
}


