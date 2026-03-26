using System;

using System;
using System.IO;

class Program
{
    static readonly string WorkDir = Path.Combine(Environment.CurrentDirectory, "TestFiles");
    static FileManager fm = new FileManager();
    static FileInfoProvider fip = new FileInfoProvider();

    static void Main(string[] args)
    {
        Directory.CreateDirectory(WorkDir); 

        Console.WriteLine("╔═════════════════╗");
        Console.WriteLine("║   ТЕСТ ФАЙЛОВ   ║");
        Console.WriteLine("╚═════════════════╝\n");

        Task1_CreateReadFile();
        Task2_CheckBeforeDelete();
        Task3_GetFileInfo();
        Task4_CopyFile();
        Task5_MoveFile();
        Task6_RenameFile();
        Task7_HandleDeleteError();
        Task8_CompareFiles();
        Task9_DeleteByPattern();
        Task10_ListFiles();
        Task11_ReadOnlyWrite();
        Task12_CheckPermissions();

        Console.WriteLine("\n=== Тестирование завершено ===");
        Console.ReadKey();
    }

    static void Task1_CreateReadFile()
    {
        Console.WriteLine("\n========== 1. Создание и чтение ==========");
        string filePath = Path.Combine(WorkDir, "example.txt");
        fm.CreateFileWithText(filePath, "Тестовый контент.\nВторая строка.");
        Console.WriteLine($"Содержимое:\n{fm.ReadFile(filePath)}");
    }

    static void Task2_CheckBeforeDelete()
    {
        Console.WriteLine("\n========== 2. Проверка перед удалением ==========");
        string filePath = Path.Combine(WorkDir, "to_delete.txt");
        fm.CreateFileWithText(filePath, "Удаляемый файл");
        fm.DeleteFile(filePath); 
        fm.DeleteFile(filePath); 
    }

    static void Task3_GetFileInfo()
    {
        Console.WriteLine("\n========== 3. Информация о файле ==========");
        string filePath = Path.Combine(WorkDir, "info.txt");
        fm.CreateFileWithText(filePath, "Информация для демонстрации.");
        fip.PrintFileInfo(filePath);
    }

    static void Task4_CopyFile()
    {
        Console.WriteLine("\n========== 4. Копирование файла ==========");
        string source = Path.Combine(WorkDir, "source.txt");
        string copy = Path.Combine(WorkDir, "copy.txt");
        fm.CreateFileWithText(source, "Копируемый текст.");
        fm.CopyFile(source, copy);
        Console.WriteLine($"Копия существует: {File.Exists(copy)}");
    }

    static void Task5_MoveFile()
    {
        Console.WriteLine("\n========== 5. Перемещение файла ==========");
        string source = Path.Combine(WorkDir, "move_me.txt");
        string destDir = Path.Combine(WorkDir, "NewFolder");
        string dest = Path.Combine(destDir, "move_me.txt");
        fm.CreateFileWithText(source, "Перемещаемый контент.");
        fm.MoveFile(source, dest);
        Console.WriteLine($"Исходный файл существует: {File.Exists(source)}");
        Console.WriteLine($"Файл в новой папке: {File.Exists(dest)}");
    }

    static void Task6_RenameFile()
    {
        Console.WriteLine("\n========== 6. Переименование файла ==========");
        string filePath = Path.Combine(WorkDir, "old_name.txt");
        fm.CreateFileWithText(filePath, "Старое имя");
        fm.RenameFile(filePath, "mayorau.ry");
        Console.WriteLine($"Файл familiya.io существует: {File.Exists(Path.Combine(WorkDir, "familiya.io"))}");
    }

    static void Task7_HandleDeleteError()
    {
        Console.WriteLine("\n========== 7. Обработка ошибки удаления ==========");
        string nonExistent = Path.Combine(WorkDir, "nonexistent.txt");
        fm.SafeDeleteFile(nonExistent); // Ожидаем сообщение об ошибке
    }

    static void Task8_CompareFiles()
    {
        Console.WriteLine("\n========== 8. Сравнение файлов по размеру ==========");
        string file1 = Path.Combine(WorkDir, "file1.txt");
        string file2 = Path.Combine(WorkDir, "file2.txt");
        fm.CreateFileWithText(file1, "Короткий текст.");
        fm.CreateFileWithText(file2, "Значительно более длинный текст для демонстрации разницы в размере файлов.");
        fip.CompareFilesBySize(file1, file2);
    }

    static void Task9_DeleteByPattern()
    {
        Console.WriteLine("\n========== 9. Удаление по шаблону (*.ii) ==========");
        fm.CreateFileWithText(Path.Combine(WorkDir, "file1.ii"), ".");
        fm.CreateFileWithText(Path.Combine(WorkDir, "file2.ii"), ".");
        fm.CreateFileWithText(Path.Combine(WorkDir, "keep.txt"), ".");
        fm.DeleteFilesByPattern(WorkDir, "*.ii");
        Console.WriteLine($"Файлы в директории: {string.Join(", ", fm.ListFiles(WorkDir).Select(Path.GetFileName))}");
    }

    static void Task10_ListFiles()
    {
        Console.WriteLine("\n========== 10. Список файлов ==========");
        fm.CreateFileWithText(Path.Combine(WorkDir, "doc.pdf"), "...");
        fm.CreateFileWithText(Path.Combine(WorkDir, "data.csv"), "...");
        string[] files = fm.ListFiles(WorkDir);
        Console.WriteLine($"Всего файлов: {files.Length}");
        foreach (var file in files)
        {
            Console.WriteLine($"  - {Path.GetFileName(file)}");
        }
    }

    static void Task11_ReadOnlyWrite()
    {
        Console.WriteLine("\n========== 11. Запрет записи ==========");
        string filePath = Path.Combine(WorkDir, "readonly.txt");
        fm.CreateFileWithText(filePath, "Доступно для записи.");
        fm.SetReadOnly(filePath, true); 
        fm.TryWriteToFile(filePath, "Не должно записаться"); 
        fm.SetReadOnly(filePath, false); 
        fm.TryWriteToFile(filePath, "Теперь запись разрешена."); 
    }

    static void Task12_CheckPermissions()
    {
        Console.WriteLine("\n========== 12. Проверка прав ==========");
        string filePath = Path.Combine(WorkDir, "perms.txt");
        fm.CreateFileWithText(filePath, "Проверка прав");
        fip.CheckFilePermissions(filePath); 
        fm.SetReadOnly(filePath, true); 
        fip.CheckFilePermissions(filePath); 
        fm.SetReadOnly(filePath, false); 
    }
}