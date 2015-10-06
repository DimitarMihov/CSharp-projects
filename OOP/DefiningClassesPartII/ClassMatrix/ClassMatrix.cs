/*Task 8
 * Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).
 * 
 * Task 9
 * Implement an indexer this[row, col] to access the inner matrix cells.
 * 
 * Task 10
 * Implement the operators + and - (addition and subtraction of matrices of the same size)
 * and * for matrix multiplication. Throw an exception when the operation cannot be performed.
 * Implement the true operator (check for non-zero elements).
 */


using System;
using System.Text;

class Matrix<T> where T: struct
{
    const int DefaultRows = 100;
    const int DefaultCols = 100;

    private int CountRow { get; set; }
    private int CountCol { get; set; }

    private T[,] elements;
    
    public Matrix()
    {
        elements = new T[DefaultRows, DefaultCols];
    }

    public Matrix(int row, int col)
    {
        if (row < 0 || col < 0)
            throw new ArgumentOutOfRangeException("Negative row or col value");
        else
        {
            CountRow = row;
            CountCol = col;
            elements = new T[row, col];
        }
    }

    public Matrix(T[,] matrix)
    {
        this.elements = matrix;
        CountRow = matrix.GetLength(0);
        CountCol = matrix.GetLength(1);
    }

   public T this[int row, int col]
   {
        get
        {
            if ((row >= CountRow || row < 0) || (col >= CountCol || col < 0))
            {
                throw new IndexOutOfRangeException(String.Format("You are triyng to get element with invalid index"));
            }

            T result = elements[row, col];
            return result;
        }
       set
       {
           if (CountRow < row || CountCol < col || row < 0 || col < 0)
               throw new ArgumentOutOfRangeException("Index out of range for Row or Col");
           else
               elements[row, col] = value;
       }
   }

   

    public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
    {
        if (matrix1.CountRow != matrix2.CountRow || matrix1.CountCol != matrix2.CountCol)
        {
            throw new ArgumentException("The two matrices are in different sizes!");
        }
        
        try
        {
            Matrix<T> summedMatrix = new Matrix<T>(matrix1.CountRow, matrix1.CountCol);
            for (int i = 0; i < matrix1.CountRow; i++)
            {
                for (int j = 0; j < matrix1.CountCol; j++)
                {
                    summedMatrix[i, j] = (dynamic)matrix1[i, j] + matrix2[i, j];
                }
            }

            return summedMatrix;
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The action \"addition \" can not be applied on these types!");
            return null;
        }
    }

    public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
    {
        if (matrix1.CountRow != matrix2.CountRow || matrix1.CountCol != matrix2.CountCol)
        {
            throw new ArgumentException("The two matrices are in different sizes!");
        }

        try
        {
            Matrix<T> summedMatrix = new Matrix<T>(matrix1.CountRow, matrix1.CountCol);
            for (int i = 0; i < matrix1.CountRow; i++)
            {
                for (int j = 0; j < matrix1.CountCol; j++)
                {
                    summedMatrix[i, j] = (dynamic)matrix1[i, j] - matrix2[i, j];
                }
            }

            return summedMatrix;
        }
        catch (ArgumentException)
        {

            Console.WriteLine("The action \"subtraction \" can not be applied on these types!");
            return null;
        }
    }

    public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
    {
        if (matrix1.CountRow != matrix2.CountRow || matrix1.CountCol != matrix2.CountCol)
        {
            throw new ArgumentException("The two matrices are in different sizes!");
        }

        try
        {
            Matrix<T> summedMatrix = new Matrix<T>(matrix1.CountRow, matrix1.CountCol);
            for (int i = 0; i < matrix1.CountRow; i++)
            {
                for (int j = 0; j < matrix1.CountCol; j++)
                {
                    summedMatrix[i, j] = (dynamic)matrix1[i, j] * matrix2[i, j];
                }
            }

            return summedMatrix;
        }
        catch (ArgumentException)
        {
            
            Console.WriteLine("The action \"multiplication \" can not be applied on these types!");
            return null;
        }
    }

    public static bool operator true(Matrix<T> matrix)
    {
        int zero = 0;
        for (int i = 0; i < matrix.CountRow; i++)
        {
            for (int j = 0; j < matrix.CountCol; j++)
            {
                if ((dynamic)matrix[i,j] == zero)
                {
                    return false;
                }
            }
        }

        return true;
    }

    public static bool operator false(Matrix<T> matrix)
    {
        int zero = 0;
        for (int i = 0; i < matrix.CountRow; i++)
        {
            for (int j = 0; j < matrix.CountCol; j++)
            {
                if ((dynamic)matrix[i, j] == zero)
                {
                    return false;
                }
            }
        }

        return true;
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < CountRow; i++)
        {
            for (int j = 0; j < CountCol; j++)
            {
                builder.Append(elements[i, j] + " ");
            }

            builder.AppendLine();
        }

        return builder.ToString();
    }
}
