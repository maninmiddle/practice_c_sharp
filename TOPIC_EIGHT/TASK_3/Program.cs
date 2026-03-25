using System;

public class Program
{
    public static void Main()
    {
        IRepository<Product> repository = new MemoryRepository<Product>();
        RepositoryManager<Product> manager = new RepositoryManager<Product>(repository);

        manager.AddItem(new Product(1, "Ноутбук"));
        manager.AddItem(new Product(2, "Мышь"));
        manager.AddItem(new Product(3, "Клавиатура"));

        Console.WriteLine("Все элементы:");
        manager.DisplayAll();

        Console.WriteLine();

        Product found = manager.Find(p => p.Name.Equals("Мышь"));
        if (found != null)
            Console.WriteLine("Найден элемент: " + found);
        else
            Console.WriteLine("Элемент не найден.");

        Console.WriteLine();

        manager.RemoveItem(found); 
    }
}