namespace SequenceOfMaximalSum
{
    ////Write a program that finds the sequence of maximal sum in given array. Example:
    ////{2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}

    using System;

    class SequenceOfMaximalSum
    {
        static void Main()
        {
            int[] array = { 2, 3, -6, -1, 2, -1, -5, 6, 4, -8, 8 };
            int maxStartPoint = 0;
            int maxEndPoint = 0;
            int maxSum = 0;
            int bestmaxSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    maxSum += array[j];

                    if (maxSum > bestmaxSum)
                    {
                        bestmaxSum = maxSum;
                        maxStartPoint = i;
                        maxEndPoint = j;
                    }
                }

                maxSum = 0;
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
