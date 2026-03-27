using System;

public interface IReportBuilder
{
    IReportBuilder SetTitle(string title);
    IReportBuilder SetHeader(string header);
    IReportBuilder SetBody(string body);
    IReportBuilder AddTable(string tableDescription);
    IReportBuilder AddChart(string chartDescription);
    IReportBuilder SetFooter(string footer);
    Report Build();
}
