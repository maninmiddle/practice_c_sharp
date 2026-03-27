public class ArraySorter
{
    private ISortingStrategy _strategy;

    public ArraySorter(ISortingStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(ISortingStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Sort(int[] array)
    {
        _strategy.Sort(array);
    }

    public static void PrintArray(int[] array)
    {
        Console.WriteLine("[" + string.Join(", ", array) + "]");
    }
}
