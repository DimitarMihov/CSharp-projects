using System;

class CalculateVariableArguments
{
    static void Main()
    {
        Console.WriteLine("Please, enter three arguments, separated by \"Enter\"!");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        
        int min = Min(a, b, c);
        int max = Max(a, b, c);
        int sum = Sum(a, b, c);
        int average = Average(a, b, c);
        int product = Product(a, b, c);

        Console.WriteLine("Min: {0}.\nMax: {1}.\nSum: {2}.\nAverage: {3}.\nProduct: {4}.", min, max, sum, average, product);
    }
    
    static int Min(params int[] sequence)
    {
        int sequenceLength = sequence.GetLength(0);
        if (sequenceLength > 0)
        {
            if (sequenceLength == 2)
            {
                return sequence[0] < sequence[1] ? sequence[0] : sequence[1];
            }
            else
            {
                int result = sequence[0];
                for (int i = 1; i < sequenceLength; ++i)
                {
                    result = Math.Min(result, sequence[i]);
                }
                return result;
            }
        }
        else
        {
            return 0;
        }
    }

    static int Max(params int[] sequence)
    {
        int sequenceLength = sequence.GetLength(0);
        if (sequenceLength > 0)
        {
            if (sequenceLength == 2)
            {
                return sequence[0] > sequence[1] ? sequence[0] : sequence[1];
            }
            else
            {
                int result = sequence[0];
                for (int i = 1; i < sequenceLength; ++i)
                {
                    result = Max(result, sequence[i]);
                }
                return result;
            }
        }
        else
        {
            return 0;
        }
    }

    static int Sum(params int[] sequence)
    {
        int sum = 0;
        foreach (int x in sequence)
        {
            sum += x;
        }
        return sum;
    }

    static int Average(params int[] sequence)
    {
        int sum = 0, sequenceLength = sequence.GetLength(0);
        foreach (int x in sequence)
        {
            sum += x;
        }

        return sum / sequenceLength;
    }

    static int Product(params int[] sequence)
    {
        if (sequence.GetLength(0) > 0)
        {
            int product = 1;
            foreach (int x in sequence)
            {
                product *= x;
            }

            return product;
        }
        else
        {
            return 0;
        }
    }
}
