using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        string input = Console.ReadLine();

        int maxDigit = int.MinValue;
        int minDigit = int.MaxValue;

        foreach (char c in input)
        {
            int digit = c - '0'; 

            if (digit > maxDigit) maxDigit = digit;
            if (digit < minDigit) minDigit = digit;
        }

        Console.WriteLine($"Наибольшая цифра: {maxDigit}");
        Console.WriteLine($"Наименьшая цифра: {minDigit}");
    }
}
