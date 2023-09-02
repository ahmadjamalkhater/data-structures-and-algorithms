using System;

class Program
{
    static void Merge(int[] arr, int[] left, int[] right)
    {
        int nLeft = left.Length;
        int nRight = right.Length;
        int i = 0, j = 0, k = 0;

        while (i < nLeft && j < nRight)
        {
            if (left[i] <= right[j])
            {
                arr[k] = left[i];
                i++;
            }
            else
            {
                arr[k] = right[j];
                j++;
            }
            k++;
        }

        while (i < nLeft)
        {
            arr[k] = left[i];
            i++;
            k++;
        }

        while (j < nRight)
        {
            arr[k] = right[j];
            j++;
            k++;
        }
    }

    static void MergeSortAlgorithm(int[] arr)
    {
        int n = arr.Length;

        if (n <= 1)
            return;

        int mid = n / 2;
        int[] left = new int[mid];
        int[] right = new int[n - mid];

        for (int i = 0; i < mid; i++)
            left[i] = arr[i];

        for (int i = mid; i < n; i++)
            right[i - mid] = arr[i];

        MergeSortAlgorithm(left);
        MergeSortAlgorithm(right);

        Merge(arr, left, right);
    }

    static void MergeSort(int[] arr)
    {
        MergeSortAlgorithm(arr);
    }

    static void Main(string[] args)
    {
        int[] arr = { 8, 4, 23, 42, 16, 15 };

        Console.WriteLine("Original array: " + string.Join(", ", arr));
        MergeSort(arr);
        Console.WriteLine("Sorted array: " + string.Join(", ", arr));
    }
}
