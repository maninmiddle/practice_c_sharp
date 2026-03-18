using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());
        
        Console.Write("Введите количество столбцов: ");
        int cols = int.Parse(Console.ReadLine());
        
        if (cols < 2)
        {
            Console.WriteLine("Массив должен иметь минимум 2 столбца");
            return;
        }
        
        int[,] array = new int[rows, cols];
        Random rand = new Random();
        
        Console.WriteLine("\nИсходный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = rand.Next(1, 20);
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
        
        long product = 1;
        for (int i = 0; i < rows; i++)
        {
            product *= array[i, 1];
        }
        
        Console.WriteLine($"\nПроизведение элементов второго столбца: {product}");
        
        if (product >= 100 && product <= 999)
        {
            Console.WriteLine("Произведение является трехзначным числом");
        }
        else
        {
            Console.WriteLine("Произведение НЕ является трехзначным числом");
        }
    }
}
