namespace FillAndPrintMatrix
{
    using System;

    /*Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)*/

    class FillAndPrintMatrix
    {
        static void Main()
        {
            Console.Write("Please, enter a number for the rows and columns lenght: ");
            string lenght = Console.ReadLine();
            int n = int.Parse(lenght);

            //Variant "a"
            Console.WriteLine("Variant \"A\"");
            int[,] matrixA = new int[n, n];
            int num = 1;
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    matrixA[row, col] = num;
                    num++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write((matrixA[i, j] < 10) ? "  {0}" : " {0}", matrixA[i, j]);
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            //Variant "b"
            Console.WriteLine("Variant \"B\"");
            int[,] matrixB = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int multiplier = 0;
                for (int col = 0; col < n; col++)
                {
                    int cell;
                    if (col % 2 == 0)
                    {
                        cell = (multiplier * n) + (row + 1);
                    }
                    else
                    {
                        cell = ((2 + multiplier) * n) - row;
                        multiplier = multiplier + 2;
                    }

                    matrixB[row, col] = cell;
                    Console.Write((matrixB[row, col] < 10) ? "  {0}" : " {0}", matrixB[row, col]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            //Variant "c"
            Console.WriteLine("Variant \"C\"");
            int[,] matrixC = new int[n, n];

            int startRow = n - 1;
            int startCol = 0;

            int rowC = startRow;
            int colC = startCol;
            int number = 1;
            matrixC[rowC, colC] = number;

            while (number < n * n)
            {
                startRow--;

                if (startRow >= 0)
                {
                    startCol = 0;
                    rowC = startRow;
                    colC = startCol;

                    while ((rowC < n && colC < n) ? true : false)
                    {

                        number++;
                        matrixC[rowC, colC] = number;
                        rowC++;
                        colC++;
                    }
                }
                else
                {
                    startRow = 0;
                    startCol++;

                    rowC = startRow;
                    colC = startCol;


                    while ((rowC < n && colC < n) ? true : false)
                    {
                        number++;
                        matrixC[rowC, colC] = number;
                        rowC++;
                        colC++;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write((matrixC[i, j] < 10) ? "  {0}" : " {0}", matrixC[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
