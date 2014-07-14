namespace SubsetOfIntegers
{
   // We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. 
    
    using System;
    using System.Collections.Generic;

    class SubsetOfIntegers
    {
        static void Main()
        {
            int[] numbers = {3, -2, -3, 1, 1, 1, 8};
            List<int> subset = new List<int>();
            int sum;
            bool hasZeroSubset = false;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                subset.Clear();
                subset.Add(numbers[i]);
                sum = 0;
                sum += numbers[i];
                
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    subset.Add(numbers[j]);
                    sum += numbers[j];

                    if (sum == 0)
                    {
                        hasZeroSubset = true;
                        break;
                    }
                }

                if (hasZeroSubset)
                {
                    break;
                }
            }

            if (hasZeroSubset)
            {
                for (int n = 0; n < subset.Count; n++)
                {
                    Console.Write("{0}, ", subset[n]);
                }
            }
            else
            {
                Console.WriteLine("There is not zero subset.");
            }

            Console.WriteLine();
        }
    }
}
