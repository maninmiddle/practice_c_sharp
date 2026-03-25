using System;

public class Program
{
    public static void Main()
    {
        ListManager<int> manager = new ListManager<int>();

        manager.AddItem(5);
        manager.AddItem(2);
        manager.AddItem(8);
        manager.AddItem(1);

        Console.WriteLine("Список:");
        manager.PrintAll();

        manager.SortItems((a, b) => a.CompareTo(b));

        Console.WriteLine("\nПосле сортировки:");
        manager.PrintAll();

        int found = manager.FindItem(x => x > 3);
        Console.WriteLine($"\nПервый элемент > 3: {found}");

        manager.RemoveItem(2);

        Console.WriteLine("\nПосле удаления:");
        manager.PrintAll();
    }
}