using System;

//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
//    N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}



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
