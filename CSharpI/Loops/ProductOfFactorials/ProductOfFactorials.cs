namespace ProductOfFactorials
{
    //Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
    
    using System;

    class ProductOfFactorials
    {
        static void Main()
        {
            Console.WriteLine("Enter numbers K and N where 1 < N < K");
            Console.Write("Enter number N: ");
            int numberN = int.Parse(Console.ReadLine());
            Console.Write("Enter number K: ");
            int numberK = int.Parse(Console.ReadLine());
            int product = 1;
            int nFactorial = 0;
            int kFactorial = 0;
            int divisor = 0;

            while (true)
            {
                if (numberN > 1 && numberN < numberK)
                {
                    break;
                }

                Console.WriteLine("Numbers must be in a sequence 1 < N < K");
                Console.Write("Enter number N: ");
                numberN = int.Parse(Console.ReadLine());
                Console.Write("Enter number K: ");
                numberK = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= numberN; i++)
            {
                product *= i;
            }

            nFactorial = product;
            product = 1;

            for (int i = 1; i <= numberK; i++)
            {
                product *= i;
            }

            kFactorial = product;
            product = 1;

            for (int i = 1; i <= (numberK - numberN); i++)
            {
                product *= i;
            }

            divisor = product;

            double result = (nFactorial * kFactorial) / divisor;

            Console.WriteLine(result);
        }
    }
}
