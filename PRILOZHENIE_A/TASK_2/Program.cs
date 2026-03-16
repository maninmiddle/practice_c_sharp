using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Введите двузначное число: ");
        int number = int.Parse(Console.ReadLine());
        
        int first = number / 10;
        int last = number % 10;
        
        Console.WriteLine($"Первая цифра: {first}");
        Console.WriteLine($"Последняя цифра: {last}\n");
    }
}