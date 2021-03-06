﻿using System;
using System.Numerics;

class CalculateNFaktorial
{
    static void Main()
    {
        int[] arr = new int[100];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i + 1;
        }
        CalculateFactorialOfN(arr);

    }
    static void CalculateFactorialOfN(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            BigInteger factorial = Factorial(i);
            Console.WriteLine(factorial);
        }
    }
    static BigInteger Factorial(int i)
    {
        BigInteger fact = i;
        while (i > 0)
        {
            fact *= i;
            i--;
        }
        return fact;
    }
}
