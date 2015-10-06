using System;

class LastDigitAsWord
{
    static void Main()
    {
        Console.Write("Please, enter an integer value: ");
        int value = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("The last digit of the value is {0}", ValueAsWord(value));
    }

    static string ValueAsWord (int value)
    {
        string[] word = new string[] {"zero", "one", "two", "three", "four",
                                       "five", "six", "seven", "eight", "nine"};
        value = value % 10;
        value = Math.Abs(value);
        return word[value];
    }
}

