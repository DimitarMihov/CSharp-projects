using System;

class MaximalElementInSection
{
    static void Main()
    {
        int[] array = new int[] { 10, 51, 24, 5, 16, 7, 18, 31, 42, 10, -5, 6, 0 };
        int sectionStart = 3;
        int sectionLenght = 5;

        int maximal = FindMaximal(array, sectionStart, sectionLenght);
        Console.WriteLine(maximal);
        SortDescending(array);
        PrintArray(array);
    }

    static int FindMaximal(int[] arr, int start, int len)
    {
        int maximal = int.MinValue;
        int maximalIndex = 0;
        for (int i = start; i < start + len; i++)
        {
            if (arr[i] > maximal)
            {
                maximal = arr[i];
                maximalIndex = i;
            }
        }
        int temp = arr[maximalIndex];
        arr[maximalIndex] = arr[start];
        arr[start] = temp;
        return maximal;
    }

    static int[] SortDescending(int[] arr)
    {
        int maximalElement = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            maximalElement = FindMaximal(arr, i, arr.Length - i);
            arr[i] = maximalElement;
            maximalElement = int.MinValue;
        }
        return arr;
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
