namespace FibonacciSequence
{
    //Write a program to print the first 100 members of the sequence of Fibonacci:0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
    
    using System;
    using System.Numerics;

    class FibonacciSequence
    {
        static void Main()
        {
            Console.WriteLine("0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377,");
            Console.WriteLine("The first 100 members of the sequence of Fibonacci are:");
            BigInteger firstNumber = new BigInteger(0);
            BigInteger secondNumber = new BigInteger(1);

            for (int i = 0; i < 100; i++)
            {
                Console.Write("{0}, {1}", firstNumber, secondNumber);
                firstNumber += secondNumber;
                secondNumber += firstNumber;
                if (i != 99)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }
    }
}
