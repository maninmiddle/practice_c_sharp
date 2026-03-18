using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();
        
        string vowels = "аеёиоуыэюяАЕЁИОУЫЭЮЯaeiouAEIOU";
        int vowelCount = 0;
        int consonantCount = 0;
        
        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                if (vowels.Contains(c))
                {
                    vowelCount++;
                }
                else
                {
                    consonantCount++;
                }
            }
        }
        
        Console.WriteLine($"Количество гласных: {vowelCount}");
        Console.WriteLine($"Количество согласных: {consonantCount}");
    }
}
