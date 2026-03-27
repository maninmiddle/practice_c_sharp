using System;

public class MergeSort : ISortingStrategy
{
    public void Sort(int[] array)
    {
        Console.WriteLine("Sorting using Merge Sort...");
        MergeSortRecursive(array, 0, array.Length - 1);
    }

    private void MergeSortRecursive(int[] array, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            MergeSortRecursive(array, left, mid);
            MergeSortRecursive(array, mid + 1, right);
            Merge(array, left, mid, right);
        }
    }

    private void Merge(int[] array, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] leftArr = new int[n1];
        int[] rightArr = new int[n2];

        Array.Copy(array, left, leftArr, 0, n1);
        Array.Copy(array, mid + 1, rightArr, 0, n2);

        int i = 0, j = 0, k = left;

        while (i < n1 && j < n2)
        {
            if (leftArr[i] <= rightArr[j])
                array[k++] = leftArr[i++];
            else
                array[k++] = rightArr[j++];
        }

        while (i < n1)
            array[k++] = leftArr[i++];

        while (j < n2)
            array[k++] = rightArr[j++];
    }
}
