using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество баллов (0-100): ");
        int score = int.Parse(Console.ReadLine());

        switch (score / 10)
        {
            case 10:
            case 9:
                Console.WriteLine("Отлично");
                break;
            case 8:
            case 7:
                Console.WriteLine("Хорошо");
                break;
            case 6:
            case 5:
                Console.WriteLine("Удовлетворительно");
                break;
            default:
                if (score >= 0 && score < 50)
                    Console.WriteLine("Неудовлетворительно");
                else
                    Console.WriteLine("Некорректный балл");
                break;
        }
    }
}
