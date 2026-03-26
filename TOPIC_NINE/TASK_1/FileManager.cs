using System;


public class FileManager
{
    public void CreateFileWithText(string filePath, string content)
    {
        string directory = Path.GetDirectoryName(filePath);
        if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }
        File.WriteAllText(filePath, content);
        Console.WriteLine($"[OK] Файл создан: {filePath}");
    }

    public string ReadFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"Файл не найден: {filePath}");
        }
        return File.ReadAllText(filePath);
    }

    public bool DeleteFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"[WARN] Файл не существует: {filePath}");
            return false;
        }
        File.Delete(filePath);
        Console.WriteLine($"[OK] Файл удалён: {filePath}");
        return true;
    }

    public void SafeDeleteFile(string filePath)
    {
        try
        {
            File.Delete(filePath);
            Console.WriteLine($"[OK] Файл удалён: {filePath}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"[ERROR] Файл не найден для удаления: {filePath}");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine($"[ERROR] Нет прав на удаление: {filePath}");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"[ERROR] Ошибка ввода-вывода при удалении {filePath}: {ex.Message}");
        }
    }

    public bool CopyFile(string sourcePath, string destinationPath, bool overwrite = false)
    {
        if (!File.Exists(sourcePath))
        {
            Console.WriteLine($"[ERROR] Исходный файл не найден: {sourcePath}");
            return false;
        }
        string destDir = Path.GetDirectoryName(destinationPath);
        if (!string.IsNullOrEmpty(destDir) && !Directory.Exists(destDir))
        {
            Directory.CreateDirectory(destDir);
        }
        File.Copy(sourcePath, destinationPath, overwrite);

        bool copyExists = File.Exists(destinationPath);
        Console.WriteLine(copyExists ? $"[OK] Файл скопирован: {destinationPath}" : "[ERROR] Копирование не удалось");
        return copyExists;
    }

    public bool MoveFile(string sourcePath, string destinationPath)
    {
        if (!File.Exists(sourcePath))
        {
            Console.WriteLine($"[ERROR] Исходный файл не найден: {sourcePath}");
            return false;
        }
        string destDir = Path.GetDirectoryName(destinationPath);
        if (!string.IsNullOrEmpty(destDir) && !Directory.Exists(destDir))
        {
            Directory.CreateDirectory(destDir);
        }
        File.Move(sourcePath, destinationPath);
        Console.WriteLine($"[OK] Файл перемещён: {destinationPath}");
        return true;
    }

    public bool RenameFile(string filePath, string newFileName)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"[ERROR] Файл не найден: {filePath}");
            return false;
        }
        string directory = Path.GetDirectoryName(filePath);
        string newPath = Path.Combine(directory ?? "", newFileName);
        File.Move(filePath, newPath);
        Console.WriteLine($"[OK] Файл переименован: {newFileName}");
        return true;
    }

    public int DeleteFilesByPattern(string directoryPath, string pattern)
    {
        if (!Directory.Exists(directoryPath))
        {
            Console.WriteLine($"[ERROR] Директория не найдена: {directoryPath}");
            return 0;
        }
        string[] files = Directory.GetFiles(directoryPath, pattern);
        int count = 0;
        foreach (string file in files)
        {
            try
            {
                File.Delete(file);
                count++;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  Ошибка удаления {Path.GetFileName(file)}: {ex.Message}");
            }
        }
        Console.WriteLine($"[OK] Удалено файлов ({pattern}): {count}");
        return count;
    }

    public string[] ListFiles(string directoryPath)
    {
        if (!Directory.Exists(directoryPath))
        {
            Console.WriteLine($"[ERROR] Директория не найдена: {directoryPath}");
            return Array.Empty<string>();
        }
        return Directory.GetFiles(directoryPath);
    }

    public void SetReadOnly(string filePath, bool readOnly)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"[ERROR] Файл не найден: {filePath}");
            return;
        }
        FileAttributes attributes = File.GetAttributes(filePath);
        if (readOnly)
        {
            File.SetAttributes(filePath, attributes | FileAttributes.ReadOnly);
            Console.WriteLine($"[OK] Файл сделан ReadOnly: {filePath}");
        }
        else
        {
            File.SetAttributes(filePath, attributes & ~FileAttributes.ReadOnly);
            Console.WriteLine($"[OK] Атрибут ReadOnly снят: {filePath}");
        }
    }

    public bool TryWriteToFile(string filePath, string content)
    {
        try
        {
            File.WriteAllText(filePath, content);
            Console.WriteLine($"[OK] Запись в файл выполнена: {filePath}");
            return true;
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine($"[ERROR] Запись запрещена: {filePath}");
            return false;
        }
        catch (IOException ex)
        {
            Console.WriteLine($"[ERROR] Ошибка ввода-вывода при записи {filePath}: {ex.Message}");
            return false;
        }
    }
}