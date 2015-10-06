using System;

//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. Example:
//    N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}


class AllVariationsKN
{
    
    static int numberOfLoops;
    static int numberOfIterations;
    static int[] loops;

    static void Main()
    {
        Console.Write("N = ");
        numberOfLoops = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        numberOfIterations = int.Parse(Console.ReadLine());
        loops = new int[numberOfLoops];
        NestedLoops();
    }

    static void NestedLoops()
    {
        InitLoops();
        int currentPosition;
        while (true)
        {
            PrintLoops();
            currentPosition = numberOfLoops - 1;
            loops[currentPosition] = loops[currentPosition] + 1;
            while (loops[currentPosition] > numberOfIterations)
            {
                loops[currentPosition] = 1;
                currentPosition--;
                if (currentPosition < 0)
                {
                    return;
                }

            loops[currentPosition] = loops[currentPosition] + 1;
            }
        }
    }

    static void InitLoops()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                loops[i] = 1;
            }
        }

        static void PrintLoops()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                Console.Write("{0} ", loops[i]);
            }

            Console.WriteLine();
        }
}
