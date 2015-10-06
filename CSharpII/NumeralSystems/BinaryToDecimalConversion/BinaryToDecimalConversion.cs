using System;
using System.Collections.Generic;

class BinaryToDecimalConversion
{
    //Write a program to convert binary numbers to their decimal representation.
    
    static void Main()
    {
        Console.Write("Please, enter a number in bynary format: ");
        string byNum = Console.ReadLine();
        List<byte> byteNum = new List<byte>();
        foreach (var num in byNum)
        {
            byte number = (byte) (num - '0');
            byteNum.Add(number);
        }
        byteNum.Reverse();

        int n = byteNum.Count;
        int decNum = 0;
        for (int i = 0; i < n; i++)
        {
            double power = Math.Pow(2, i);
            decNum += byteNum[i] * (int)power;
        }

        Console.WriteLine("The decimal equivalent of the number is: {0}", decNum);
    }
}
