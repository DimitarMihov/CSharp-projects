using System;

//Write a program that finds all prime numbers in the range [1...10 000 000].
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).


class PrimeNumbers
{
    static void Main()
    {
        int arrIndex = 10000000;
        int[] numbers = new int[arrIndex];
        bool[] prime = new bool[arrIndex];
        for (int i = 2; i < arrIndex; i++)
        {
            numbers[i] = i;
            prime[i] = true;
        }

        for (int i = 2; i < Math.Sqrt(10000000); i++)
        {
            for (int j = i * i; j < arrIndex; j += i)
            {
                prime[j] = false;
            }
        }

        int k = 0;
        for (int i = 0; i < arrIndex; i++)
        {
            if (prime[i] == true)
            {
                Console.Write(" ," + numbers[i]);
                //Console.Write(", ");
                k++;
            }
        }

        Console.WriteLine();
        Console.WriteLine("The sum of all prime numbers is {0}", k);
    }
}
