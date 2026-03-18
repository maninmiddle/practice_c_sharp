using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[100];
        Random rand = new Random();
        
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(1, 101);
        }
        
        Console.WriteLine("Исходный массив (первые 20 чисел):");
        for (int i = 0; i < 20; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine("\n");
        
        Console.WriteLine("Числа в обратном порядке по 6 в строке:");
        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            Console.Write(numbers[i] + "\t");
            if ((numbers.Length - i) % 6 == 0)
                Console.WriteLine();
        }
        Console.WriteLine("\n");
        
        Array.Sort(numbers);
        Console.WriteLine("Отсортированный массив (первые 20 чисел):");
        for (int i = 0; i < 20; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
        
        Console.Write("Введите число k для поиска: ");
        int k = int.Parse(Console.ReadLine());
        
        int index = Array.BinarySearch(numbers, k);
        if (index >= 0)
        {
            Console.WriteLine($"Число {k} найдено на позиции {index}");
        }
        else
        {
            Console.WriteLine($"Число {k} не найдено");
        }
    }
}
