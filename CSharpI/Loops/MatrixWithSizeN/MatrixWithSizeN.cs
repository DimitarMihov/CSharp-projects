namespace MatrixWithSizeN
{
    //Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following: ...
    
    using System;

    class MatrixWithSizeN
    {
        static void Main()
        {
            Console.WriteLine("Enter a positive integer number N < 20 : ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int n = i;
                
                for (int j = 0; j < number; j++)
                {
                    Console.Write(n);
                    n++;
                }

                Console.WriteLine("\n");
            }
        }
    }
}
