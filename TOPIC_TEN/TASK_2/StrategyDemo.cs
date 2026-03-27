public class StrategyDemo
{
    public static void Run()
    {
        int[] data = { 38, 27, 43, 3, 9, 82, 10 };

        int[] copy1 = (int[])data.Clone();
        var sorter = new ArraySorter(new BubbleSort());
        sorter.Sort(copy1);
        ArraySorter.PrintArray(copy1);

        int[] copy2 = (int[])data.Clone();
        sorter.SetStrategy(new QuickSort());
        sorter.Sort(copy2);
        ArraySorter.PrintArray(copy2);

        int[] copy3 = (int[])data.Clone();
        sorter.SetStrategy(new MergeSort());
        sorter.Sort(copy3);
        ArraySorter.PrintArray(copy3);
    }
}
