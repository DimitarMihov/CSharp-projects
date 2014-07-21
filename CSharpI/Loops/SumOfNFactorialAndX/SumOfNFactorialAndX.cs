namespace SumOfNFactorialAndX
{
    //Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N
    
    using System;

    class SumOfNFactorialAndX
    {
        static void Main()
        {
            Console.Write("Enter integer number N: ");
            double numberN = double.Parse(Console.ReadLine());
            Console.Write("Enter integer number X: ");
            double numberX = double.Parse(Console.ReadLine());
            double sum = 1;
            
            for (double i = 1; i <= numberN; i++)
            {
                double product = 1;

                for (double j = 1; j <= i; j++)
                {
                    product *= j;
                }

                sum += product / Math.Pow(numberX, i);
            }

            Console.WriteLine("The result is {0}", sum);
        }
    }
}
