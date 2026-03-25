using System;

public class RepositoryManager<T>
{
    private IRepository<T> repository;

    public RepositoryManager(IRepository<T> repository)
    {
        this.repository = repository;
    }

    public void AddItem(T item)
    {
        repository.Add(item);
    }

    public void RemoveItem(T item)
    {
        bool result = repository.Remove(item);

        if (result)
            Console.WriteLine("Элемент удалён.");
        else
            Console.WriteLine("Элемент не найден.");
    }

    public void DisplayAll()
    {
        foreach (var item in repository.GetAll())
        {
            Console.WriteLine(item);
        }
    }

    public T Find(Func<T, bool> predicate)
    {
        return repository.GetAll().FirstOrDefault(predicate);
    }
}