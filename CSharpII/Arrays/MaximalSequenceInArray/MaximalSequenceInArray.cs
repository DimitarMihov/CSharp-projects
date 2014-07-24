namespace MaximalSequenceInArray
{
    //Write a program that finds the maximal sequence of equal elements in an array.
    
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MaximalSequenceInArray
    {
        static void Main()
        {
            int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1, 5, 5, 5, 5, 1 };
            List<int> sequence = new List<int>();
            List<int> buffer = new List<int>();
            buffer.Add(array[0]);

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i-1] == array[i])
                {
                    buffer.Add(array[i]);
                }
                else if (array[i - 1] != array[i])
                {
                    if (buffer.Count() > sequence.Count())
                    {
                        sequence.Clear();
                        sequence.AddRange(buffer);
                    }

                    buffer.Clear();
                    buffer.Add(array[i]);
                }

                if (i == array.Length - 1)
                {
                    if (buffer.Count() > sequence.Count())
                    {
                        sequence.Clear();
                        sequence.AddRange(buffer);
                    }
                }

            }

            foreach (var item in sequence)
            {
                Console.Write("{0}, ", item);
            }

        }
    }
}
