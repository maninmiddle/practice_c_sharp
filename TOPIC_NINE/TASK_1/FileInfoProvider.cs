using System;

public class FileInfoProvider
{
    public void PrintFileInfo(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"[ERROR] Файл не найден: {filePath}");
            return;
        }
        FileInfo fi = new FileInfo(filePath);
        Console.WriteLine($"\n--- Информация о файле: {fi.Name} ---");
        Console.WriteLine($"  Размер:          {fi.Length} байт ({FormatSize(fi.Length)})");
        Console.WriteLine($"  Дата создания:   {fi.CreationTime:dd.MM.yyyy HH:mm:ss}");
        Console.WriteLine($"  Дата изменения:  {fi.LastWriteTime:dd.MM.yyyy HH:mm:ss}");
        Console.WriteLine($"  Атрибуты:        {fi.Attributes}");
        Console.WriteLine($"  ReadOnly:        {fi.IsReadOnly}");
    }

    public long GetFileSize(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"Файл не найден: {filePath}");
        }
        return new FileInfo(filePath).Length;
    }

    public void CompareFilesBySize(string filePath1, string filePath2)
    {
        if (!File.Exists(filePath1) || !File.Exists(filePath2))
        {
            Console.WriteLine("[ERROR] Один или оба файла не найдены для сравнения.");
            return;
        }
        long size1 = new FileInfo(filePath1).Length;
        long size2 = new FileInfo(filePath2).Length;
        string name1 = Path.GetFileName(filePath1);
        string name2 = Path.GetFileName(filePath2);

        Console.WriteLine($"\n--- Сравнение: {name1} ({FormatSize(size1)}) vs {name2} ({FormatSize(size2)}) ---");
        if (size1 > size2) Console.WriteLine($"  '{name1}' больше '{name2}' на {size1 - size2} байт");
        else if (size1 < size2) Console.WriteLine($"  '{name2}' больше '{name1}' на {size2 - size1} байт");
        else Console.WriteLine($"  Файлы одинакового размера.");
    }

    public void CheckFilePermissions(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"[ERROR] Файл не найден: {filePath}");
            return;
        }
        FileInfo fi = new FileInfo(filePath);

        Console.WriteLine($"\n--- Права доступа: {fi.Name} ---");
        Console.WriteLine($"  ReadOnly:       {fi.IsReadOnly}");
        Console.WriteLine($"  Атрибуты:       {fi.Attributes}");

        bool canRead = CheckAccess(filePath, FileMode.Open, FileAccess.Read);
        Console.WriteLine($"  Чтение:         {(canRead ? "✔ Разрешено" : "✘ Запрещено")}");

        bool canWrite = CheckAccess(filePath, FileMode.Open, FileAccess.Write);
        Console.WriteLine($"  Запись:         {(canWrite ? "✔ Разрешено" : "✘ Запрещено")}");
    }

    private bool CheckAccess(string filePath, FileMode mode, FileAccess access)
    {
        try
        {
            using (FileStream fs = new FileStream(filePath, mode, access)) { }
            return true;
        }
        catch
        {
            return false;
        }
    }

    private string FormatSize(long bytes)
    {
        string[] suffixes = { "Б", "КБ", "МБ", "ГБ", "ТБ" };
        int index = 0;
        double size = bytes;
        while (size >= 1024 && index < suffixes.Length - 1)
        {
            size /= 1024;
            index++;
        }
        return $"{size:F2} {suffixes[index]}";
    }
}