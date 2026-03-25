using System;

using System.Collections.Generic;

public class MemoryRepository<T> : IRepository<T>
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public bool Remove(T item)
    {
        return items.Remove(item);
    }

    public IEnumerable<T> GetAll()
    {
        return items;
    }
}