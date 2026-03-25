using System;

using System;

public class ListManager<T>
{
    private MyList<T> list = new MyList<T>();

    public void AddItem(T item)
    {
        list.Add(item);
    }

    public void RemoveItem(T item)
    {
        if (!list.Remove(item))
            Console.WriteLine("Элемент не найден");
    }

    public T FindItem(Predicate<T> predicate)
    {
        return list.Find(predicate);
    }

    public void SortItems(Comparison<T> comparison)
    {
        list.Sort(comparison);
    }

    public void PrintAll()
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
    }
}