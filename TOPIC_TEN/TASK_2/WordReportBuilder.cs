using System;

public class WordReportBuilder : IReportBuilder
{
    private Report _report = new Report();

    public WordReportBuilder()
    {
        _report.Format = "Word";
    }

    public IReportBuilder SetTitle(string title)
    {
        _report.Title = $"[Word] {title}";
        return this;
    }

    public IReportBuilder SetHeader(string header)
    {
        _report.Header = $"[Word Header] {header}";
        return this;
    }

    public IReportBuilder SetBody(string body)
    {
        _report.Body = $"[Word Body] {body}";
        return this;
    }

    public IReportBuilder AddTable(string tableDescription)
    {
        _report.Tables.Add($"[Word Table] {tableDescription}");
        return this;
    }

    public IReportBuilder AddChart(string chartDescription)
    {
        _report.Charts.Add($"[Word Chart] {chartDescription}");
        return this;
    }

    public IReportBuilder SetFooter(string footer)
    {
        _report.Footer = $"[Word Footer] {footer}";
        return this;
    }

    public Report Build()
    {
        Report result = _report;
        _report = new Report { Format = "Word" };
        return result;
    }
}
