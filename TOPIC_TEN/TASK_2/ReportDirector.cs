public class ReportDirector
{
    private IReportBuilder _builder;

    public ReportDirector(IReportBuilder builder)
    {
        _builder = builder;
    }

    public void SetBuilder(IReportBuilder builder)
    {
        _builder = builder;
    }

    public Report BuildFullReport()
    {
        return _builder
            .SetTitle("Annual Financial Report 2024")
            .SetHeader("Company: ABC Corp | Date: 2024-12-01")
            .SetBody("This report contains detailed financial analysis for the fiscal year 2024.")
            .AddTable("Revenue by Quarter")
            .AddTable("Expenses Breakdown")
            .AddChart("Revenue Growth Chart")
            .AddChart("Profit Margin Pie Chart")
            .SetFooter("Confidential — Page 1 of 10")
            .Build();
    }

    public Report BuildShortReport()
    {
        return _builder
            .SetTitle("Short Summary Report")
            .SetHeader("Quick Overview")
            .SetBody("Summary of key metrics.")
            .AddTable("Key Metrics Table")
            .SetFooter("End of Report")
            .Build();
    }
}
