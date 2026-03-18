using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку для проверки: ");
        string input = Console.ReadLine();
        
        string cleaned = Regex.Replace(input, @"\s+", "").ToLower();
        
        bool isPalindrome = true;
        for (int i = 0; i < cleaned.Length / 2; i++)
        {
            if (cleaned[i] != cleaned[cleaned.Length - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }
        
        if (isPalindrome)
        {
            Console.WriteLine("Строка является палиндромом");
        }
        else
        {
            Console.WriteLine("Строка НЕ является палиндромом");
        }
    }
}
