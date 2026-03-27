using System;

public class ExcelReportBuilder : IReportBuilder
{
    private Report _report = new Report();

    public ExcelReportBuilder()
    {
        _report.Format = "Excel";
    }

    public IReportBuilder SetTitle(string title)
    {
        _report.Title = $"[Excel] {title}";
        return this;
    }

    public IReportBuilder SetHeader(string header)
    {
        _report.Header = $"[Excel Header] {header}";
        return this;
    }

    public IReportBuilder SetBody(string body)
    {
        _report.Body = $"[Excel Body] {body}";
        return this;
    }

    public IReportBuilder AddTable(string tableDescription)
    {
        _report.Tables.Add($"[Excel Table] {tableDescription}");
        return this;
    }

    public IReportBuilder AddChart(string chartDescription)
    {
        _report.Charts.Add($"[Excel Chart] {chartDescription}");
        return this;
    }

    public IReportBuilder SetFooter(string footer)
    {
        _report.Footer = $"[Excel Footer] {footer}";
        return this;
    }

    public Report Build()
    {
        Report result = _report;
        _report = new Report { Format = "Excel" };
        return result;
    }
}
