namespace DivisionOfFactorials
{
    //Write a program that calculates N!/K! for given N and K (1<K<N).
    
    using System;

    class DivisionOfFactorials
    {
        static void Main()
        {
            Console.WriteLine("Enter numbers K and N where 1 < K < N");
            Console.Write("Enter number K: ");
            int numberK = int.Parse(Console.ReadLine());
            Console.Write("Enter number N: ");
            int numberN = int.Parse(Console.ReadLine());
            int product = 1;

            while (true)
            {
                if (numberK > 1 && numberK < numberN)
                {
                    break;
                }

                Console.WriteLine("Numbers must be in a sequence 1 < K < N");
                Console.Write("Enter number K: ");
                numberK = int.Parse(Console.ReadLine());
                Console.Write("Enter number N: ");
                numberN = int.Parse(Console.ReadLine());
            }

            for (int i = numberN; i > numberK; i--)
            {
                product *= i;
            }

            Console.WriteLine("The result of N!/K! is: {0}", product);
        }
    }
}
