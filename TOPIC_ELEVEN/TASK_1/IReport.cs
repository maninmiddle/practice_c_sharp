using System;

public interface IReport
{
        string ReportType { get; }
        void Generate();
        void Save(string path);
}
