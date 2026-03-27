using System;

public class QuickSort : ISortingStrategy
{
    public void Sort(int[] array)
    {
        Console.WriteLine("Sorting using Quick Sort...");
        QuickSortRecursive(array, 0, array.Length - 1);
    }

    private void QuickSortRecursive(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high);
            QuickSortRecursive(array, low, pivotIndex - 1);
            QuickSortRecursive(array, pivotIndex + 1, high);
        }
    }

    private int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        int tmp = array[i + 1];
        array[i + 1] = array[high];
        array[high] = tmp;

        return i + 1;
    }
}

