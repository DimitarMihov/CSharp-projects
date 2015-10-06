using System;

class CountsNumberInArray
{
    static void Main()
    {
        int[] arr = CreateAndFillArray();
        int number = arr.Length;
        Console.Write("Please, enter a number between 0 and {0}: ", (number *3 / 4) -1);
        int element = int.Parse (Console.ReadLine());

        Console.WriteLine("The number of elements is: {0}", CountElementInArray(arr, element));
    }

    private static int CountElementInArray(int[] arr, int element)
    {
        int counter = 0;
        foreach (var num in arr)
        {
            if (num == element)
            {
                counter++;
            }
        }

        return counter;
    }

    private static int[] CreateAndFillArray()
    {
        Console.Write("Please, enter the number of elements of the array: ");
        int lenghtArr = int.Parse(Console.ReadLine());
        int[] arr = new int[lenghtArr];

        int elementNum = lenghtArr * 3 / 4;
        Random rand = new Random();
        Console.WriteLine("The elements of the array are:");
        for (int i = 0; i < lenghtArr; i++)
        {
            arr[i] = rand.Next(0, elementNum);
            Console.Write(arr[i] + ", ");
        }
        Console.WriteLine();
        return arr;
    }
}