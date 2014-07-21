namespace NMembersOfFibonacciSequence
{
    //Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 
    //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

    using System;
    using System.Numerics;

    class NMembersOfFibonacciSequence
    {
        static void Main()
        {
            Console.Write("Enter count N of members of the Fibonacci sequence: ");
            int countOfSequence = int.Parse(Console.ReadLine());
            
            Console.WriteLine("0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377,");
            Console.WriteLine("The first {0} members of the sequence of Fibonacci are:", countOfSequence);
            BigInteger firstNumber = new BigInteger(0);
            BigInteger secondNumber = new BigInteger(1);

            for (int i = 0; i < countOfSequence; i++)
            {
                Console.Write("{0}, {1}", firstNumber, secondNumber);
                firstNumber += secondNumber;
                secondNumber += firstNumber;
                if (i != countOfSequence - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }
    }
}
