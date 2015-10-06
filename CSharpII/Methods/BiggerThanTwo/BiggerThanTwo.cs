using System;

class BiggerThanTwo
{
    static void Main()
    {
        int[] arr = CreateAndFillArray();
        Console.Write("Please, enter a position of element between 2 and {0}: ", arr.Length - 1);
        int pos = (int.Parse(Console.ReadLine()) - 1);

        string bigger = BiggerOfTwo(arr[pos], arr[pos - 1], arr[pos + 1]);
        Console.Write("The element at position {0} is {1} than it's neighbors!", pos + 1, bigger);
        Console.WriteLine();
    }

    private static string BiggerOfTwo(int main, int left, int right)
    {
        string bigger = "not bigger";
        if (right >= main)
        {
            //not bigger
        }
        else if (left >= main)
        {
            //not bigger
        }
        else
        {
            bigger = "bigger";
        }

        return bigger;
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