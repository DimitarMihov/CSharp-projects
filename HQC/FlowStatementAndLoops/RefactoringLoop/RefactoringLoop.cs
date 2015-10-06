namespace RefactoringLoop
{
    using System;

    internal class RefactoringLoop
    {
        static void Main()
        {
            int[] array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            Console.WriteLine("Please input integer between 1 and 100, divisible by 10: ");
            int expectedValue = int.Parse(Console.ReadLine());

            bool isValueFound = false;

            for (int i = 0; i < 100; i++)
            {
                if (i % 10 == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        isValueFound = true;
                        break;
                    }
                }
            }

            ////More code here

            if (isValueFound)
            {
                Console.WriteLine("Value found");
            }
            else
            {
                Console.WriteLine("Value was not found");
            }
        }
    }
}
