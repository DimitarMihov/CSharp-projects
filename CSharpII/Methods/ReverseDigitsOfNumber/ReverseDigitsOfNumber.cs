using System;

class ReverseDigitsOfNumber
{
    static void Main()
    {
        Console.Write("Please, enter a number: ");
        string stringNum = Console.ReadLine();

        ReverseDigits(stringNum);
    }

    private static int[] ReverseDigits(string stringNum)
    {
        int arrLenght = stringNum.Length;
        int number = int.Parse(stringNum);
        int[] arr = new int[arrLenght];

        for (int i = 0; i < arrLenght; i++)
        {
            arr[i] = number % 10;
            number = number / 10;

        }

        Console.Write("The reversed number is: ");

        foreach (var element in arr)
        {
            Console.Write(element);
        }

        Console.WriteLine();
        return arr;
    }
}
