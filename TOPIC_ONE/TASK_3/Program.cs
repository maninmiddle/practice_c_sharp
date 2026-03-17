using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число K: ");
        int K = int.Parse(Console.ReadLine());
        Console.Write("Введите число N: ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            if (i > 0) Console.Write(" ");
            Console.Write(K);
        }
        Console.WriteLine();
    }
}
