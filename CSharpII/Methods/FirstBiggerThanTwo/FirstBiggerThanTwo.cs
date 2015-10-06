using System;

class FirstBiggerThanTwo
{
        static void Main()
    {
        int[] arr = CreateAndFillArray();
        while (arr.Length < 3)
        {
            Console.WriteLine("At least three elements are needed! Please, enter a number more than 3!");
            arr = CreateAndFillArray();
        }

        int pos = ReturnPosition(arr);

        if (pos != - 1)
        {
            Console.Write("The element at position {0} is first bigger than it's neighbors!", pos + 1);
        }
        else
        {
            Console.Write("There is not such element, bigger than others.");
        }
            
        Console.WriteLine();
    }

        private static int ReturnPosition(int[] arr)
        {
            int bigger = -1;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if ((BiggerOfTwo(arr[i], arr[i - 1], arr[i + 1])) != -1)
                {
                    bigger = i;
                    break;
                }
            }
            return bigger;
        }

        private static int BiggerOfTwo(int main, int left, int right)
        {
            int bigger = -1;
            if (right >= main)
            {
                //not bigger
            }
            else if (left >= main)
            {
                //not bigger
            }
            else
            {
                bigger = main;
            }

            return bigger;
        }

        private static int[] CreateAndFillArray()
        {
            Console.Write("Please, enter the number of elements of the array: ");
            int lenghtArr = int.Parse(Console.ReadLine());
            int[] arr = new int[lenghtArr];

            int elementNum = lenghtArr * 3 / 4;
            Random rand = new Random();
            Console.WriteLine("The elements of the array are:");
            for (int i = 0; i < lenghtArr; i++)
            {
                arr[i] = rand.Next(0, elementNum);
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine();
            return arr;
        }
    
}
