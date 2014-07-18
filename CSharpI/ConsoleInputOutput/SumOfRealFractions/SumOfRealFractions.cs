namespace SumOfRealFractions
{
    //Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
    
    using System;

    class SumOfRealFractions
    {
        static void Main()
        {
            decimal i = 2;
            decimal sum = 1;
            decimal sumTemp = 0;

            while (true)
            {
                sumTemp = sum;
                
                if (i % 2 == 0)
                {
                    sum += 1 / i;
                }
                else
                {
                    sum -= 1 / i;
                }

                if (Math.Abs(sum - sumTemp) < 0.001m)
                {
                    break;
                }

                i++;
            }

            Console.WriteLine("The sum with accuracy of 0.001 is {0}", sum);
        }
    }
}
