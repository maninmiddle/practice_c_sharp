using System; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Делегат для обработки строк ===\n");
        
        string testString = "Hello World! C# Delegates Are Great!";
        
        Console.WriteLine($"Исходная строка: \"{testString}\"\n");
        
        Console.WriteLine("1. Передача метода ToUpperCase:");
        ProcessString(testString, ToUpperCase);
        
        Console.WriteLine("\n2. Передача метода ToLowerCase:");
        ProcessString(testString, ToLowerCase);
        
        Console.WriteLine("\n3. Передача лямбда-выражения (добавляем восклицательные знаки):");
        ProcessString(testString, s => s + "!!!");
        
        Console.WriteLine("\n4. Передача анонимного метода (реверс строки):");
        ProcessString(testString, delegate(string s) 
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        });
    }
    
    static void ProcessString(string input, StringProcessor processor)
    {
        Console.WriteLine($"  Исходная строка: \"{input}\"");
        
        if (processor != null)
        {
            string result = processor(input);
            Console.WriteLine($"  Результат обработки: \"{result}\"");
        }
        else
        {
            Console.WriteLine("  Ошибка: делегат не установлен");
        }
    }
    
    static string ToUpperCase(string input)
    {
        Console.WriteLine("  [Callback] Выполняется ToUpperCase...");
        return input.ToUpper();
    }
    
    static string ToLowerCase(string input)
    {
        Console.WriteLine("  [Callback] Выполняется ToLowerCase...");
        return input.ToLower();
    }
}