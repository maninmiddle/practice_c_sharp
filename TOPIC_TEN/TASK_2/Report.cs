using System;

public class Report
{
    public string Title { get; set; }
    public string Header { get; set; }
    public string Body { get; set; }
    public string Footer { get; set; }
    public string Format { get; set; }
    public List<string> Charts { get; set; } = new List<string>();
    public List<string> Tables { get; set; } = new List<string>();

    public void Display()
    {
        Console.WriteLine("========== REPORT ==========");
        Console.WriteLine($"Format : {Format}");
        Console.WriteLine($"Title  : {Title}");
        Console.WriteLine($"Header : {Header}");
        Console.WriteLine($"Body   : {Body}");

        if (Tables.Count > 0)
        {
            Console.WriteLine("Tables :");
            foreach (var table in Tables)
                Console.WriteLine($"  - {table}");
        }

        if (Charts.Count > 0)
        {
            Console.WriteLine("Charts :");
            foreach (var chart in Charts)
                Console.WriteLine($"  - {chart}");
        }

        Console.WriteLine($"Footer : {Footer}");
        Console.WriteLine("============================");
    }
}
