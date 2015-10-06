using System;
using System.IO;

class MaximalSumInTextFile
{
    /*Write a program that reads a text file containing a square matrix of numbers
     * and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements.
     * The first line in the input file contains the size of matrix N. Each of the next
     * N lines contain N numbers separated by space. The output should be a single number
     * in a separate text file.*/
    
    static void Main()
    {
        string folderName = "Ex_5";
        string source = "\\Matrix.txt";
        string target = "\\Target.txt";


        CreateTargetFile(folderName, source, target);
        Console.WriteLine("Target file was created!");
    }

    private static void CreateTargetFile(string folderName, string source, string target)
    {
        int maxSum = CalculateMaximalSum(folderName, source);
        StreamWriter result = new StreamWriter(@"..\..\..\TestFiles\" + folderName + target);
        using (result)
        {
            result.WriteLine(maxSum.ToString());
        }
    }

    private static int CalculateMaximalSum(string folderName, string fileName1)
    {
        int[,] matrix = ReadMatrixFromFile(folderName, fileName1);
        int maxSum = int.MinValue;
        int startRow = -1;
        int startCol = -1;
        int rowPl = 2;
        int colPl = 2;
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

        return maxSum;
    }

    private static int[,] ReadMatrixFromFile(string folderName, string fileName1)
    {
        StreamReader sourceFileOne = new StreamReader(@"..\..\..\TestFiles\" + folderName + fileName1);
        using (sourceFileOne)
        {
            string line = sourceFileOne.ReadLine();
            int n = int.Parse(line);
            int[,] matrix = new int[n, n];
            string[] row = new string[n];

            for (int i = 0; i < n; i++)
            {
                line = sourceFileOne.ReadLine();
                row = line.Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(row[j]);
                }
            }

            return matrix;
        }
    }
}