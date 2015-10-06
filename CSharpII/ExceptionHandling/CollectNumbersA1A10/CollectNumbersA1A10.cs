using System;
using System.Collections.Generic;

class CollectNumbersA1A10
{
    /*Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end].
     * If an invalid number or non-number text is entered, the method should throw an exception.
     * Using this method write a program that enters 10 numbers:
			a1, a2, … a10, such that 1 < a1 < … < a10 < 100 */

    static void Main()
    {
        int start = 1;
        int end = 100;
        int offset = start;
        List<int> numbers = new List<int>();
        int i = 0;
        while (true)
        {
            try
            {
                while (i < 10)
                {
                    offset = ReadNumber(offset, end);
                    numbers.Add(offset);
                    i++;
                }

                Console.Write("The numbers you have entered are:");
                foreach (var item in numbers)
                {
                    Console.Write(" {0}, ", item);
                }
                Console.WriteLine();
                return;
            }
            catch (ArgumentOutOfRangeException)
            {

                Console.WriteLine("The nubmer is out of given range!");
            }
            catch (FormatException)
            {
                Console.WriteLine("You have entered an invalid number or non-number text");
            } 
        }
    }

    static int ReadNumber(int start, int end)
    {
        Console.WriteLine("Please, enter an integer number bigger than {0} and smaller than {1}", start, end);
        int number = int.Parse(Console.ReadLine());
        if (number <= start || number >= end)
        {
            throw new ArgumentOutOfRangeException();
        }
        return number;
    }

}
