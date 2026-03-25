using System;

using System;

public class MyList<T>
{
    private T[] items;
    private int count;

    public int Count => count;

    public MyList(int capacity = 4)
    {
        items = new T[capacity];
        count = 0;
    }

    private void Resize()
    {
        int newSize = items.Length * 2;
        T[] newArray = new T[newSize];

        for (int i = 0; i < items.Length; i++)
            newArray[i] = items[i];

        items = newArray;
    }

    public void Add(T item)
    {
        if (count == items.Length)
            Resize();

        items[count++] = item;
    }

    public bool Remove(T item)
    {
        for (int i = 0; i < count; i++)
        {
            if (Equals(items[i], item))
            {
                for (int j = i; j < count - 1; j++)
                    items[j] = items[j + 1];

                count--;
                return true;
            }
        }
        return false;
    }

    public T Find(Predicate<T> predicate)
    {
        for (int i = 0; i < count; i++)
        {
            if (predicate(items[i]))
                return items[i];
        }
        return default;
    }

    public void Sort(Comparison<T> comparison)
    {
        for (int i = 0; i < count - 1; i++)
        {
            for (int j = 0; j < count - i - 1; j++)
            {
                if (comparison(items[j], items[j + 1]) > 0)
                {
                    // swap
                    T temp = items[j];
                    items[j] = items[j + 1];
                    items[j + 1] = temp;
                }
            }
        }
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException();

            return items[index];
        }
    }
}