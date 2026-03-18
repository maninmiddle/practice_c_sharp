using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк в ступенчатом массиве: ");
        int rows = int.Parse(Console.ReadLine());
        
        int[][] jaggedArray = new int[rows][];
        
        for (int i = 0; i < rows; i++)
        {
            Console.Write($"Введите количество элементов в строке {i + 1}: ");
            int cols = int.Parse(Console.ReadLine());
            jaggedArray[i] = new int[cols];
        }
        
        Random rand = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                jaggedArray[i][j] = rand.Next(1, 10);
            }
        }
        
        Console.WriteLine("\nИсходный ступенчатый массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
        
        int[][] resultArray = new int[rows][];
        for (int i = 0; i < rows; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                rowSum += jaggedArray[i][j];
            }
            
            resultArray[i] = new int[jaggedArray[i].Length];
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                resultArray[i][j] = rowSum;
            }
        }
        
        Console.WriteLine("\nРезультирующий ступенчатый массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < resultArray[i].Length; j++)
            {
                Console.Write(resultArray[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
