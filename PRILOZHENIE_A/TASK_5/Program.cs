using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Введите четырехзначное число: ");
        string inputNumberStr = Console.ReadLine();
        int number = int.Parse(inputNumberStr);
        
        int sumOfDigits = 0;
        foreach (char digit in inputNumberStr)
        {
            sumOfDigits += int.Parse(digit.ToString());
        }
        Console.WriteLine($"Сумма цифр: {sumOfDigits}\n");
    }
}