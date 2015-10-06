namespace LongestSequence
{
    using System;

    /*We are given a matrix of strings of size N x M. Sequences in the matrix we define
     * as sets of several neighbor elements located on the same line, column or diagonal.
     * Write a program that finds the longest sequence of equal strings in the matrix.*/

    class LongestSequence
    {
        static void Main()
        {
            Console.Write("Please, enter a number of the rows bigger than '1': ");
            int nRow = int.Parse(Console.ReadLine());

            while (nRow < 2)
            {
                Console.Write("Please, enter a value bigger than '1': ");
                nRow = int.Parse(Console.ReadLine());
            }

            Console.Write("Please, enter a number of the columns bigger than '1': ");
            int nCol = int.Parse(Console.ReadLine());

            while (nCol < 2)
            {
                Console.Write("Please, enter a value bigger than '1': ");
                nCol = int.Parse(Console.ReadLine());
            }

            //Words for matrix to be filled in
            string[] petNames = new string[40] { "MAX", "BUDDY", "JAKE", "BAILEY", 
                                               "ROCKY", "CHARLIE", "JACK", "TOBY", 
                                               "CODY", "BUSTER", "DUKE", "COOPER", 
                                               "HARLEY", "RILEY", "BEAR", "MURPHY", 
                                               "LUCKY", "TUCKER", "SAMY", "OLIVER", 
                                               "MOLLY", "BELLA", "LUCY", "MAGGIE", 
                                               "DAISY", "SADIE", "CHLOE", "SOPHIE", 
                                               "BAILEY", "ZOEM", "LOLA", "ABBY", 
                                               "GINGER", "ROXY", "GRACIE", "COCO", 
                                               "SASHA", "ANGEL", "LILY", "PRINCESS" 
                                            };


            String[,] matrix = new string[nRow, nCol];
            Console.WriteLine("String array: ");

            //Fill in the matrix with 3 letter words
            Random rand = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int random = rand.Next(1, ((nRow * nCol < 100) ? (nRow * nCol / 3) : petNames.Length));
                    string shortName = petNames[random];
                    string shortN = shortName.Remove(3);
                    matrix[i, j] = shortN;
                    Console.Write("{0}, ", matrix[i, j]);
                }

                Console.WriteLine();

            }

            //Search within the matrix
            int maxCount = 1;
            int startRow = 0;
            int startCol = 0;
            int direction = 0;

            //Check by rows
            int firstRow = 0;
            int firstCol = 0;

            int differ;
            for (int i = 0; i < nRow; i++)
            {
                firstRow = i;
                firstCol = 0;
                int currentCount = 1;
                for (int j = 0; j < (nCol - 1); j++)
                {
                    differ = matrix[i, j].CompareTo(matrix[i, j + 1]);
                    if (differ != 0)
                    {
                        currentCount = 1;
                        firstCol = j + 1;
                    }
                    if (differ == 0)
                    {
                        currentCount++;
                    }

                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;

                        startRow = firstRow;
                        startCol = firstCol;
                        direction = 1;

                    }
                }
            }


            //Check by columns
            firstRow = 0;
            firstCol = 0;
            for (int i = 0; i < nCol; i++) // Column counter
            {
                firstCol = i;
                firstRow = 0;
                int currentCount = 1;
                for (int j = 0; j < (nRow - 1); j++) //Row counter
                {
                    differ = matrix[j, i].CompareTo(matrix[j + 1, i]);
                    if (differ != 0)
                    {
                        currentCount = 1;
                        firstRow = j + 1;
                    }
                    else
                    {
                        currentCount++;
                    }

                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        currentCount = 1;
                        startRow = firstRow;
                        startCol = firstCol;
                        direction = 2;
                    }
                }
            }


            //Check by diagonals
            firstRow = nRow - 1;
            firstCol = 0;

            int rowC = firstRow;
            int colC = firstCol;
            //int number = 1;
            //matrixC[rowC, colC] = number;

            while (!((firstRow == 0) && (firstCol == nCol - 1)))
            {
                firstRow--;

                if (firstRow >= 0)
                {
                    firstCol = 0;
                    rowC = firstRow;
                    colC = firstCol;
                    int currentCount = 1;

                    while (rowC < nRow - 1 && colC < nCol - 1)
                    {

                        differ = matrix[rowC, colC].CompareTo(matrix[rowC + 1, colC + 1]);
                        if (differ != 0)
                        {
                            currentCount = 1;
                        }
                        else
                        {
                            currentCount++;
                        }

                        if (currentCount > maxCount)
                        {
                            maxCount = currentCount;
                            currentCount = 1;
                            startRow = firstRow;
                            startCol = firstCol;
                            direction = 3;
                        }
                        //number++;
                        //matrixC[rowC, colC] = number;
                        rowC++;
                        colC++;
                    }
                }
                else
                {
                    firstRow = 0;
                    firstCol++;

                    rowC = firstRow;
                    colC = firstCol;
                    int currentCount = 1;

                    while (rowC < nRow - 1 && colC < nCol - 1)
                    {
                        differ = matrix[rowC, colC].CompareTo(matrix[rowC + 1, colC + 1]);
                        if (differ != 0)
                        {
                            currentCount = 1;
                        }
                        else
                        {
                            currentCount++;
                        }

                        if (currentCount > maxCount)
                        {
                            maxCount = currentCount;
                            currentCount = 1;
                            startRow = firstRow;
                            startCol = firstCol;
                            direction = 3;
                        }
                        //number++;
                        //matrixC[rowC, colC] = number;
                        rowC++;
                        colC++;
                    }
                }
            }


            Console.Write("Number of elements {0}, ", maxCount);
            //Console.WriteLine(direction);

            switch (direction)
            {
                case 1: Console.WriteLine("in a row, with index {0},{1} .", startRow, startCol); break;
                case 2: Console.WriteLine("in a column, with index {0},{1} .", startRow, startCol); break;
                case 3: Console.WriteLine("in a diagonal, with index {0},{1}.", startRow, startCol); break;
                default: Console.WriteLine("Output error!"); break;
            }
        }
    }
}
