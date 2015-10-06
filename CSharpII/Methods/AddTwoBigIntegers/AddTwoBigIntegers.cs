using System;

class AddTwoBigIntegers
{
    static void Main()
    {
        Console.WriteLine("Please, enter the lenght of numbers to add!");
        Console.WriteLine("The lenght must be between 0 and 10 000!");
        Console.Write("Lenght of number 1: ");
        int lenght1 = int.Parse(Console.ReadLine());
        Console.Write("Lenght of number 2: ");
        int lenght2 = int.Parse(Console.ReadLine());
        Console.WriteLine();

        //int[] longArr = {1,2,3,4}; //for testing purposes
        //int[] shortArr = {7,8,9};
        //Console.Write("0");
        //PrintArrayReverse(longArr);
        //Console.Write("0");
        //PrintArrayReverse(shortArr);


        int[] longArr;
        int[] shortArr;
        if (lenght1 > lenght2)
        {
            longArr = CreateBigIntArray(lenght1);
            shortArr = CreateBigIntArray(lenght2);
        }
        else
        {
            longArr = CreateBigIntArray(lenght2);
            shortArr = CreateBigIntArray(lenght1);
        }
        
        int carry = 0;
        int i = 0;
        int[] arr3 = new int[GetMax(lenght1, lenght2) + 1];

        while (i < GetMin(lenght1, lenght2))
        {
            if ((longArr[i] + shortArr[i] + carry) < 10)
            {
                arr3[i] = longArr[i] + shortArr[i] + carry;
                carry = 0;
            }
            else
            {
                arr3[i] = (longArr[i] + shortArr[i] + carry) % 10;
                carry = 1;
            }

            i++;
        }

        while (i < GetMax(lenght1, lenght2))
        {
            
            
            if ((longArr[i] + carry) < 10)
            {
                arr3[i] = longArr[i] + carry;
                carry = 0;
            }
            else
            {
                arr3[i] = (longArr[i] + carry) % 10;
                carry = 1;
            }

            i++;
        }

        PrintArrayReverse(arr3);

    }

    //Create an array with random elements
    static int[] CreateBigIntArray(int lenght = 10000)
    {
        int[] arr = new int[lenght];
        Random rand = new Random(lenght);
        int i = 0;
        while (i < lenght)
        {
            arr[i] = rand.Next(10);
            i++;
        }

        PrintArrayReverse(arr);
        return arr;
    }

    private static void PrintArrayReverse(int[] arr)
    {
        for (int j = arr.Length -1; j >= 0; j--)
        {
            Console.Write(arr[j]);
        }

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

    private static int GetMin(int a, int b)
    {
        int min = a;
        if (b < a)
        {
            min = b;
        }

        return min;
    }
}
    
