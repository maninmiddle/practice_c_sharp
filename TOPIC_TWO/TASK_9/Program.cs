using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder("мир!");
        Console.WriteLine($"Исходный StringBuilder: {sb}");
        
        string prefix = "Привет, ";
        
        sb.Insert(0, prefix);
        
        Console.WriteLine($"После добавления в начало: {sb}");
        
    }
}
