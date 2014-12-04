namespace MaximalSumInSquare
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    //Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

    class MaximalSumInSquare
    {
        static void Main()
        {
            Console.Write("Please, enter a number for the rows lenght: ");
            int nRow = int.Parse(Console.ReadLine());

            Console.Write("Please, enter a number for the columns lenght: ");
            int nCol = int.Parse(Console.ReadLine());

            Random rand = new Random();
            var matrix = new int[nRow, nCol];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(1, ((nRow * nCol) / 2));
                }
            }

            Console.WriteLine("The matrix is:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write((matrix[i, j] < 10) ? "  {0}" : " {0}", matrix[i, j]);
                }

                Console.WriteLine();
            }

            Console.Write("Please, enter a number for the rows of the platform: ");
            int rowPl = int.Parse(Console.ReadLine());

            while (nRow < rowPl)
            {
                Console.Write("Please, enter a number smaller than the size of the array: ");
                rowPl = int.Parse(Console.ReadLine());
            }

            Console.Write("Please, enter a number for the columns of the platform: ");
            int colPl = int.Parse(Console.ReadLine());

            while (nCol < colPl)
            {
                Console.Write("Please, enter a number smaller than the size of the array: ");
                colPl = int.Parse(Console.ReadLine());
            }

            int maxSum = int.MinValue;
            int startRow = -1;
            int startCol = -1;
            for (int i = 0; i < matrix.GetLength(0) - (rowPl - 1); i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - (colPl - 1); j++)
                {
                    int currentSum = 0;
                    for (int platformRow = i; platformRow < i + rowPl; platformRow++)
                    {
                        for (int platformCol = j; platformCol < j + colPl; platformCol++)
                        {
                            currentSum += matrix[platformRow, platformCol];

                        }
                    }

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        startRow = i;
                        startCol = j;

                    }
                }
            }

            Console.WriteLine("The platform with the max sum is:");
            for (int i = startRow; i < rowPl + startRow; i++)
            {
                for (int j = startCol; j < colPl + startCol; j++)
                {
                    Console.Write((matrix[i, j] < 10) ? "  {0}" : " {0}", matrix[i, j]);
                }

                Console.WriteLine();
            }
            Console.WriteLine("And the sum is: {0}", maxSum);
        }
    }
}
