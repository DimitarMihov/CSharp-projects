/*Class for testing ClassMatrix class*/

using System;


class TestMatrix
{
    static void Main()
    {
        double[,] first = { { 0, 2, 3, 4.2 }, { 4, 3, 2, 1 }, { 10, 20, 30, 40 }, { 2, 4, 8, 16 } };
        double[,] second = { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 2, 2, 2, 2 } };

        Matrix<double> arrFirst = new Matrix<double>(first);
        Matrix<double> arrSecond = new Matrix<double>(second);

        //checking if contain zero, return true, if not, return false if there is zero
        if (arrFirst)
        {
            Console.WriteLine("There is no zero inside");
        }
        else
            Console.WriteLine("There is at least one zero inside\n");
        //-----------
        Console.WriteLine("Sum of the two matrices");
        Console.WriteLine(arrFirst + arrSecond);
        Console.WriteLine("Substraction of the two matrices");
        Console.WriteLine(arrFirst - arrSecond);
        Console.WriteLine("Multiplication of the two matrices");
        Console.WriteLine(arrFirst * arrSecond);
    }
}