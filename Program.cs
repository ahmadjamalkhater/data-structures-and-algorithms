using System;

class Program
{
    static void Main()
    {
        int[] inputArray = { 1, 2, 3, 4, 5, 6 };

        int[] reversedArray = ReverseArray(inputArray);
        Console.WriteLine("Reversed array (using ReverseArray):");
        PrintArray(reversedArray);

        int[] reversedArray2 = ReverseArrayWithSwap(inputArray);
        Console.WriteLine("Reversed array (using ReverseArrayWithSwap):");
        PrintArray(reversedArray2);
    }

    static int[] ReverseArray(int[] array)
    {
        int[] reversed = new int[array.Length];
        int currentIndex = 0;

        for (int i = array.Length - 1; i >= 0; i--)
        {
            reversed[currentIndex] = array[i];
            currentIndex++;
        }

        return reversed;
    }

    static int[] ReverseArrayWithSwap(int[] array)
    {
        int start = 0;
        int end = array.Length - 1;

        while (start < end)
        {
            SwapElements(array, start, end);
            start++;
            end--;
        }

        return array;
    }

    static void SwapElements(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}