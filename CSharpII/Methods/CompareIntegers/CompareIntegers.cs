using System;

class CompareIntegers
{
    static void Main()
    {
        Console.WriteLine("Please, enter three integers: ");
        int[] arr = new int [3];
        for (int i = 0; i < 3; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int maxInt = GetMax(arr[0], arr[1]);
        maxInt = GetMax(maxInt, arr[2]);

        Console.Write("The biggest number is {0}", maxInt);
        Console.WriteLine();
    }

    private static int GetMax(int a, int b)
    {
        int max = a;
        if (b > a)
        {
            max = b;
        }

        return max;
    }
}