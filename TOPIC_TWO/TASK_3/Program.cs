using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер матрицы N (N < 10): ");
        int N = int.Parse(Console.ReadLine());
        
        if (N >= 10)
        {
            Console.WriteLine("Ошибка: N должно быть меньше 10");
            return;
        }
        
        Console.Write("Введите начало диапазона a: ");
        int a = int.Parse(Console.ReadLine());
        
        Console.Write("Введите конец диапазона b: ");
        int b = int.Parse(Console.ReadLine());
        
        int[,] matrix = new int[N, N];
        Random rand = new Random();
        
        Console.WriteLine("\nИсходная матрица:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = rand.Next(a, b + 1);
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        
        int positiveCount = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (matrix[i, j] > 0)
                {
                    positiveCount++;
                }
            }
        }
        Console.WriteLine($"\nКоличество положительных чисел: {positiveCount}");
        
        Console.WriteLine("\nСумма элементов каждой строки:");
        for (int i = 0; i < N; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < N; j++)
            {
                rowSum += matrix[i, j];
            }
            Console.WriteLine($"Строка {i + 1}: {rowSum}");
        }
    }
}
