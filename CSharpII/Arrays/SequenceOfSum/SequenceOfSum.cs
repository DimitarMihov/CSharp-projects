namespace SequenceOfSum
{
    ////Write a program that finds in given array of integers a sequence of given sum S (if present). Example: {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}
    
    using System;

    class SequenceOfSum
    {
        static void Main()
        {
            int[] array = { 4, 3, 1, 4, 2, 5, 8 };
            int givenSum = 11;
            int maxStartPoint = 0;
            int maxEndPoint = 0;
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    sum += array[j];

                    if (sum == givenSum)
                    {
                        maxStartPoint = i;
                        maxEndPoint = j;
                        i = array.Length;
                        j = array.Length;
                    }
                }

                sum = 0;
            }

            for (int i = maxStartPoint; i <= maxEndPoint; i++)
            {
                Console.Write(array[i]);
                if (i != maxEndPoint)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }
    }
}
