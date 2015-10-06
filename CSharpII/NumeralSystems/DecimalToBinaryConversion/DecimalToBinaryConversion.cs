using System;
using System.Collections.Generic;

class DecimalToBinaryConversion
{
    //Write a program to convert decimal numbers to their binary representation.
    
    static void Main()
    {
        Console.Write("Please, enter a decimal number: ");
        int decNum = int.Parse(Console.ReadLine());

        List<byte> byteNum = new List<byte>();
        byte element = 0;
        while (decNum > 0)
        {
            element = (byte)(decNum % 2);
            byteNum.Add(element);
            decNum = decNum / 2;
        }

        byteNum.Reverse();
        foreach (var member in byteNum)
        {
            Console.Write(member);
        }
        Console.WriteLine();
    }
}
